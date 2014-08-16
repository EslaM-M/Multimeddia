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
        }

    }
}
