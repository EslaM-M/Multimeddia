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
                processor = new ImageProcessor(image,pictureBox1);
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
            pictureBox2.Image = bit;
        }

    }
}
