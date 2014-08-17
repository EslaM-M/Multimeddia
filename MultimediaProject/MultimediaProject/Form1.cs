using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimediaProject
{
    public partial class Form1 : Form
    {
        ImageProcessor processor;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openfile.FileName);
                processor = new ImageProcessor(image,pictureBoxNormal);
                drawMatrix(processor.GetImageMatrix((Bitmap)image));
            }
        
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            processor.Rotation();
            Color[,] color = processor.GetImageMatrix((Bitmap)processor.image);
            Bitmap bit = new Bitmap(color.GetLength(0), color.GetLength(1), System.Drawing.Imaging.PixelFormat.Format48bppRgb);
            for(int i = 0;i<color.GetLength(0);i++)
            {
                for(int j =0;j<color.GetLength(1);j++)
                {
                    bit.SetPixel(i, j, color[i, j]);
                }
            }
            pictureBoxTransformed.Image = bit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drawMatrix(Color[,] pixels)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);

            Bitmap image = new Bitmap(width, height);
            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < height; col++)
                {
                    image.SetPixel(row, col, pixels[row, col]);
                }
            }

            pictureBoxTransformed.Image = image;
        }

        private void pictureBoxNormal_MouseClick(object sender, MouseEventArgs e)
        {
            Rectangle cropRectangle = new Rectangle(e.X, e.Y, 200, 250);
            var cropped = processor.Crop(cropRectangle);
            drawMatrix(cropped);
        }


    }
}
