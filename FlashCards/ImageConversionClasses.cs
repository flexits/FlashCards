using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace FlashCards
{
    class ImageConversion
    {
        public static Image ByteToImg(byte[] sourcearray)
        {
            Image img;
            if (sourcearray == null || sourcearray.Length <= 0)
            {
                return null;
            }
            try
            {
                img = Image.FromStream(new MemoryStream(sourcearray));
            }
            catch
            {
                return null;
            }
            return img;
        }

        public static byte[] ImgToByte(Image img)
        {
            if (img == null)
            {
                return null;
            }

            /*
            //PNG and JPG only? And GIF? 
            ImageConverter imc = new ImageConverter();
            return (byte[])imc.ConvertTo(img, typeof(byte[]));*/

            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
        }

        //resize 
        //https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp/
        //https://github.com/kleisauke/net-vips/
    }
}
