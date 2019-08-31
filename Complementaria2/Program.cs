using System;
using System.IO;

namespace Complementaria2
{
    class Program
    {
        const int bufferLength = 1000;
        static void Main(string[] args)
        {
            using(var stream = new FileStream("C:\\Users\\t213\\Desktop\\prueba.txt", FileMode.Open))
            {
                using (var reader = new BinaryReader(stream))
                {
                    using(var writeStream = new FileStream("C:\\Users\\t213\\Desktop\\prueba2.txt", FileMode.OpenOrCreate))
                    {
                        using (var writer = new BinaryWriter(writeStream))
                        {
                            var byteBuffer = new byte[bufferLength];
                            while (reader.BaseStream.Position != reader.BaseStream.Length)
                            {
                                byteBuffer = reader.ReadBytes(bufferLength);
                                writer.Write(byteBuffer);
                            }
                        }
                    }   
                }
            }
            Console.ReadLine();
        }
    }
}
