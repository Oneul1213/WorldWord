using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WordWorld
{
    [Serializable]
    public static class Serializer
    {
        public static byte[] Serailze(Object obj, int size = 1024*1024)
        {
            using (MemoryStream memoryStream = new MemoryStream(size))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(memoryStream, obj);
                return memoryStream.ToArray();
            }
        }

        public static Object Deserialize(byte[] array, int size = 1024*1024)
        {
            Object obj = null ;

            using (MemoryStream memoryStream = new MemoryStream(size))
            {
                foreach (byte b in array)
                {
                    memoryStream.WriteByte(b);
                }

                memoryStream.Position = 0;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                obj = binaryFormatter.Deserialize(memoryStream);
            }

            return obj;
        }
    }
}
