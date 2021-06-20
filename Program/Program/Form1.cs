using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Bitmap image;
        public static string full_name_of_image = "\0";
        public static UInt32[,] pixel;

        //открытие изображения
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    full_name_of_image = open_dialog.FileName;
                    image = new Bitmap(open_dialog.FileName);
                    //this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Width = image.Width + 40;
                    this.Height = image.Height + 75;
                    this.pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                    //получение матрицы с пикселями
                    pixel = new UInt32[image.Height, image.Width];
                    for (int y = 0; y < image.Height; y++)
                        for (int x = 0; x < image.Width; x++)
                            pixel[y, x] = (UInt32)(image.GetPixel(x, y).ToArgb());
                }
                catch
                {
                    full_name_of_image = "\0";
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //сохранение изображения
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //string format = full_name_of_image.Substring(full_name_of_image.Length - 4, 4);
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //яркость контрастность
        private void яркостьконтрастностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 BrightnessForm = new Form2(this);
            BrightnessForm.ShowDialog(); //just 'Show' for the control Form1
        }

        //цветовой Баланс
        private void цветовойБалансToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ColorBalanceForm = new Form3(this);
            ColorBalanceForm.ShowDialog();
        }

        //Повышение резкости
        private void повыситьРезкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N1, Filter.sharpness);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }

        //Размытие
        private void размытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N2, Filter.blur);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }

        //преобразование из UINT32 to Bitmap
        public static void FromPixelToBitmap()
        {
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    image.SetPixel(x, y, Color.FromArgb((int)pixel[y, x]));
        }

        //public static void FromPixelToBitmap(UInt32[,] n_pixel)
        //{
        //    for (int y = 0; y < image.Height; y++)
        //        for (int x = 0; x < image.Width; x++)
        //            image.SetPixel(x, y, Color.FromArgb((int)n_pixel[y, x]));
        //}

        //преобразование из UINT32 to Bitmap по одному пикселю

        public static void FromOnePixelToBitmap(int x, int y, UInt32 pixel)
        {
            image.SetPixel(y, x, Color.FromArgb((int)pixel));
        }

        //вывод на экран
        public void FromBitmapToScreen()
        {
            pictureBox1.Image = image;
        }


        #region Мои Добавки

        private void DarkAVG(uint[,] pixel2)
        {
            RGB rgb = new RGB();
            RGB rgb2 = new RGB();
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    rgb.R = (float)((pixel[i, j] & 0x00FF0000)>>16);
                    rgb.G = (float)((pixel[i, j] & 0x0000FF00)>>8);
                    rgb.B = (float)(pixel[i, j] & 0x000000FF);

                    rgb2.R = (float)((pixel2[i, j] & 0x00FF0000) >> 16);
                    rgb2.G = (float)((pixel2[i, j] & 0x0000FF00) >> 8);
                    rgb2.B = (float)(pixel2[i, j] & 0x000000FF);

                    uint rezR = (uint)Math.Max(rgb.R, rgb2.R);
                    uint rezG = (uint)Math.Max(rgb.R, rgb2.R);
                    uint rezB = (uint)Math.Max(rgb.R, rgb2.R);

                    uint Color = 0xFF000000 | (rezR << 16) | (rezG << 8) | (rezB);
                    pixel[i, j] = Color;
                }
            }
        }

        private void ПревиттToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                UInt32[,] pixel_ = (UInt32[,])pixel.Clone();
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N3, Filter.Previtt, true);
                uint[,] pixel2 = Filter.matrix_filtration(image.Width, image.Height, pixel_, Filter.N3, Filter.Previtt_, true);
                DarkAVG(pixel2);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }
        private void РобертсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                UInt32[,] pixel_ = (UInt32[,])pixel.Clone();
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N4, Filter.Roberts, true);
                uint[,] pixel2 = Filter.matrix_filtration(image.Width, image.Height, pixel_, Filter.N4, Filter.Roberts_, true);
                DarkAVG(pixel2);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }
        private void СобельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                UInt32[,] pixel_ = (UInt32[,])pixel.Clone();
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N5, Filter.Sobel, true);
                uint[,] pixel2 = Filter.matrix_filtration(image.Width, image.Height, pixel_, Filter.N5, Filter.Sobel_, true);
                DarkAVG(pixel2);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }
        private void ЩаррToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                UInt32[,] pixel_ = (UInt32[,])pixel.Clone();
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N5, Filter.Sharr, true);
                uint[,] pixel2 = Filter.matrix_filtration(image.Width, image.Height, pixel_, Filter.N5, Filter.Sharr_, true);
                DarkAVG(pixel2);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = new Bitmap(full_name_of_image);
            pixel = new UInt32[image.Height, image.Width];
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    pixel[y, x] = (UInt32)(image.GetPixel(x, y).ToArgb());
            FromBitmapToScreen();
        }

        #endregion
    }
}
