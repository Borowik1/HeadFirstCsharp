using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _11___Hexdumper
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine("usage: HexDumper file-to-dump");
                Environment.Exit(1);
            }

            string fileName = args[0];

            if (!File.Exists(fileName))
            {
                Console.Error.WriteLine("File does not exist: {0}", fileName);
                Environment.Exit(1);
            }

            using (StreamReader reader = new StreamReader("six-h.dat"))
            {

                int position = 0;
                while (!reader.EndOfStream)
                {
                    char[] buffer = new char[16];
                    int charactersRead = reader.ReadBlock(buffer, 0, 16);
                    Console.Write("{0}", string.Format("{0:x4}", position));
                    for (int i = 0; i < 16; i++)
                    {
                        if (i < charactersRead)
                        {
                            string hex = string.Format("{0:x2}", (byte)buffer[i]);
                            Console.Write(hex + " ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        if (i == 7)
                        {
                            Console.Write("-- ");
                        }
                        if (buffer[i] < 32 || buffer[i] > 250) { buffer[i] = '.'; }
                    }
                    string bufferContents = new string(buffer);
                    Console.WriteLine(" " + bufferContents.Substring(0, charactersRead));
                }
            }
        }
    }
}
