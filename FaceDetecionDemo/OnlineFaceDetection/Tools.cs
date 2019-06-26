using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFaceDetection
{
    class Tools
    {
        [Obsolete("该函数待完成,请勿使用！")]
        public static string ToBase64(string picDir)
        {
            FileStream fs = File.OpenRead(picDir);
            int filelength = 0;
            filelength = (int)fs.Length;
            Byte[] image = new Byte[filelength];
            fs.Read(image, 0, filelength);
            Image img = Image.FromStream(fs);
            BinaryFormatter binFormatter = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            binFormatter.Serialize(memStream, img);
            byte[] bytes = memStream.GetBuffer();
            string base64 = Convert.ToBase64String(bytes);
            return base64;
        }

        [Obsolete("该函数待完成,请勿使用！")]
        public static Image ToImage(string base64Str)
        {
            string base64 = base64Str;
            byte[] bytes = Convert.FromBase64String(base64);
            MemoryStream memStream = new MemoryStream(bytes);
            BinaryFormatter binFormatter = new BinaryFormatter();
            Image img = (Image)binFormatter.Deserialize(memStream);
            return img;
        }
    }
}
