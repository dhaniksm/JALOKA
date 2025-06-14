using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Helpers
{
    public static class H_Konversi
    {
        public static byte[] ImageFileToByteArray(string path)
        {
            return File.ReadAllBytes(path);
        }
        public static byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
