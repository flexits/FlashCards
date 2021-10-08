using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace FlashCards
{
    /*
     * Image processing classes:
     * - conversion to/from byte[]
     * - resizing
     */
    class ImageConversion
    {
        public static Image ByteToImg(byte[] sourcearray)
        //convert array of bytes to an image or return null
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
        //convert an image to an array of bytes  or return null
        {
            if (img == null)
            {
                return null;
            }
            /*
            //PNG and JPG only? And GIF? 
            ImageConverter imc = new ImageConverter();
            return (byte[])imc.ConvertTo(img, typeof(byte[]));*/
            MemoryStream ms;
            try
            {
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
            catch
            {
                return null;
            }
        }

        //TODO resize 
        //https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp/
        //https://github.com/kleisauke/net-vips/
    }
}
