using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Util
    {
        public static byte[] ImgToByte(Image img, ImageFormat imgFormat)
        {
            Bitmap bmp = new Bitmap(img);
            MemoryStream memoryStream = new MemoryStream();
            bmp.Save(memoryStream, imgFormat);
            memoryStream.Seek(0, SeekOrigin.Begin);
            byte[] btImage = new byte[memoryStream.Length];
            memoryStream.Read(btImage, 0, btImage.Length);
            memoryStream.Close();
            return btImage;
        }

        public static Image ByteToImg(byte[] btImage)
        {
            MemoryStream memoryStream = new MemoryStream();
            memoryStream.Write(btImage, 0, btImage.Length);
            memoryStream.Position = 0;
            Image? img;
            try
            {
                img = Image.FromStream(memoryStream, true);
            }
            catch
            {
                img = null;
            }
            finally
            {
                memoryStream.Close();
            }
            return img!;
        }
    }
}
