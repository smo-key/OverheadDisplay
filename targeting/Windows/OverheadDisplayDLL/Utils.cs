using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace OverheadDisplay
{
    public class Utils
    {
        public static bool Reference(string key, int version)
        {
            //Alpha key
            if ((key == "F2E5149C-CDB6-4925-9B53-B2Y5FB5D9XFD") && (version == 1000))
            {
                _referenced = true;
            }
            return Referenced;
        }
        private static bool _referenced = false;
        public static bool Referenced { get { return _referenced; } }

        public static Bitmap MakeGrayscale(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][] 
            {
             new float[] {.3f, .3f, .3f, 0, 0},
            new float[] {.59f, .59f, .59f, 0, 0},
            new float[] {.11f, .11f, .11f, 0, 0},
            new float[] {0, 0, 0, 1, 0},
             new float[] {0, 0, 0, 0, 1}
            });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

        public static void BringToFront(Bases.DesignBase form)
        {
            form.ref_BottomPanel.BringToFront();
            form.ref_TopPanel.BringToFront();
            form.ref_Resizer.BringToFront();
        }
    }
}
