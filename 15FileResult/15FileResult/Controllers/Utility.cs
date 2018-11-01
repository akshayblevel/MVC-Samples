using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace _15FileResult.Controllers
{
    public static class Utility
    {
        public static MemoryStream GetGoGreenImage()
        {
            Uri uri = new Uri("http://www.automationanywhere.com/img/goGreen.jpg");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            MemoryStream receiveStream = null;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                if (stream != null)
                {
                    return receiveStream = ConvertStreamToMemoryStream(stream);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return receiveStream;
        }

        public static MemoryStream ConvertStreamToMemoryStream(Stream stream)
        {
            MemoryStream memoryStream = new MemoryStream();

            if (stream != null)
            {

                byte[] buffer = stream.ReadFully();

                if (buffer != null)
                {
                    var binaryWriter = new BinaryWriter(memoryStream);
                    binaryWriter.Write(buffer);
                }
            }
            return memoryStream;
        }

        public static byte[] ReadFully(this Stream input)
        {

            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}