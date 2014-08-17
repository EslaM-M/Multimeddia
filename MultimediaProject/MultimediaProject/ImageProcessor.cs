using System.Drawing;
using System.Windows.Forms;

namespace MultimediaProject
{
  public  class ImageProcessor
    {
      public  Image image;
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

      public Color[,] GetImageMatrix(Bitmap bitmap)
         {
          
             Color[,] imagematrix = new Color[bitmap.Width, bitmap.Height];

             for (int x = 0; x < bitmap.Width; x++)
             {
                 for (int y = 0; y < bitmap.Height; y++)
                 {
                    imagematrix[x,y] = bitmap.GetPixel(x, y);
                 }
             }

             return imagematrix;
         }

         
      public Color[,] Crop(Rectangle croppedRectangle)
      {
          Color[,] croppedMatrix = new Color[croppedRectangle.Width, croppedRectangle.Height];
          
          var imageMatrix = GetImageMatrix((Bitmap)image);

          for (int row = croppedRectangle.X, i = 0; i < croppedRectangle.Width; row++, i++)
          {
              for (int col = croppedRectangle.Y, j = 0; j < croppedRectangle.Height; col++, j++)
              {
                  croppedMatrix[i, j] = imageMatrix[row, col];
              }
          }

          return croppedMatrix;
      }


    }
}
