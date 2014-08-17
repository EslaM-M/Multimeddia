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
        
       //draw rectangle for cropping fields
        Rectangle _cropRectangle = new Rectangle(-1, -1, 0, 0);

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
  
          Bitmap viewbit=  processor.Rotation();
          pictureBoxTransformed.Image = viewbit;
          processor.image = viewbit;
            
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

        private void pictureBoxNormal_MouseDown(object sender, MouseEventArgs e)
        {
            _cropRectangle.X = e.X;
            _cropRectangle.Y = e.Y;
            
        }

        private void pictureBoxNormal_MouseUp(object sender, MouseEventArgs e)
        {
            _cropRectangle.Width = e.X - _cropRectangle.X;
            _cropRectangle.Height = e.Y - _cropRectangle.Y;
            var croppedMatrix = processor.Crop(_cropRectangle);
            drawMatrix(croppedMatrix);
        }

        private void Zoom_Click(object sender, EventArgs e)
        {

        }


    }
}
