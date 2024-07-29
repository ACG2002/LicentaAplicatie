using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    class PersonalizareButoane
    {
        public static void SetButtonImageRegion(Button button, string imagePath)
        {
            Bitmap image = new Bitmap(imagePath);
            GraphicsPath path = new GraphicsPath();
            path.AddPath(CreatePathFromImage(image), false);
            Region region = new Region(path);
            button.Region = region;
            button.Image = Image.FromFile(imagePath);
        }

        private static GraphicsPath CreatePathFromImage(Bitmap image)
        {
            GraphicsPath path = new GraphicsPath();
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if (image.GetPixel(x, y).A != 0)
                    {
                        path.AddRectangle(new Rectangle(x, y, 1, 1));
                    }
                }
            }
            return path;
        }
    }
}
