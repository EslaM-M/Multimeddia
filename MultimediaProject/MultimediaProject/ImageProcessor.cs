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

        public Bitmap Rotation()
        {
            //create an empty Bitmap image
            Color[,] color = this.GetImageMatrix((Bitmap)this.image);
            Bitmap bit = new Bitmap(color.GetLength(0), color.GetLength(1), System.Drawing.Imaging.PixelFormat.Format48bppRgb);
            for (int i = 0; i < color.GetLength(0); i++)
            {
                for (int j = 0; j < color.GetLength(1); j++)
                {
                    bit.SetPixel(i, j, color[color.GetLength(0) - i - 1, color.GetLength(1) - j - 1]);
                }
            }
            return bit;
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
