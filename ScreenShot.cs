using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImgNow
{
    class ScreenShot
    {
        public static void CaptureImage(bool edgeX, bool edgeY, Rectangle SelectionRectangle, string FilePath, int scaleX, int scaleY)
        {
            Rectangle ExtendedRectangle = new Rectangle(Math.Max(SelectionRectangle.X, 0), Math.Max(SelectionRectangle.Y, 0), SelectionRectangle.Width + (edgeX ? 0 : 1), SelectionRectangle.Height + (edgeY ? 0 : 1));
            Point SourcePoint = new Point(ExtendedRectangle.X, ExtendedRectangle.Y);
            using (Bitmap bitmap = new Bitmap(ExtendedRectangle.Width, ExtendedRectangle.Height, PixelFormat.Format24bppRgb))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(SourcePoint, Point.Empty, ExtendedRectangle.Size);
                }
                //a holder for the result
                Bitmap scaled = new Bitmap(scaleX, scaleY, PixelFormat.Format24bppRgb);
                // set the resolutions the same to avoid cropping due to resolution differences
                scaled.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);

                //use a graphics object to draw the resized image into the bitmap
                using (Graphics graphics = Graphics.FromImage(scaled))
                {
                    //set the resize quality modes to high quality
                    graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    //draw the image into the target bitmap
                    //ImageAttributes imageAtts = new ImageAttributes();
                    //imageAtts.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(bitmap, 0, 0, scaled.Width, scaled.Height);
                    SelectionRectangle.X = Math.Min(ExtendedRectangle.X, 1);
                    SelectionRectangle.Y = Math.Min(ExtendedRectangle.Y, 1);
                    graphics.DrawImage(bitmap, new Rectangle(0, 0, scaled.Width, scaled.Height), SelectionRectangle, GraphicsUnit.Pixel);
                }

                scaled.Save(FilePath, ImageFormat.Bmp);
            }
        }
    }
}