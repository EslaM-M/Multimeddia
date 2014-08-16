using System.Drawing;
using System.Windows.Forms;

namespace MultimediaProject
{
  public  class ImageProcessor
    {
        Image image;
        PictureBox picturebox;
   
        public ImageProcessor(Image image,PictureBox picturebox)
        {
            this.picturebox = picturebox;
            this.picturebox.Image = image;
            // TODO: Complete member initialization
            this.image = image;
        }

         public void ZoomIn()
         {
             
            
         }
        public void ZoomOut()
         {
         
         }

        public void Interprolation()
         {

         }
          
         public void Rotation()
         {
             //create an empty Bitmap image
             image.RotateFlip(RotateFlipType.Rotate180FlipY);
             this.picturebox.Image = this.image;
         }
         



    }
}
