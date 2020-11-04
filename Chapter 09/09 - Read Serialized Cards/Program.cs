using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _09___Read_Serialized_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Cards card1 = new Cards(Suits.Spades, Values.Three);
            Cards card2 = new Cards(Suits.Hearts, Values.Six);

            using (Stream output = File.Create("three-c.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, card1);
            }
            using (Stream output = File.Create("six-h.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, card2);
            }

            byte[] firstFile = File.ReadAllBytes("three-c.dat");
            byte[] secondFile = File.ReadAllBytes("six-h.dat");

            for (int i = 0; i < firstFile.Length; i++)
            {
                if (firstFile[i] != secondFile[i])
                {
                    Console.WriteLine("Byte #{0}: {1} vs {2}", i, firstFile[i], secondFile[i]);
                }
            }

            firstFile[394] = (byte)Suits.Spades;
            firstFile[333] = (byte)Values.King;
            File.Delete("king-s.dat");
            File.WriteAllBytes("king-s.dat", firstFile);

            using (Stream input = File.OpenRead("king-s.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Cards card3 = (Cards)bf.Deserialize(input);
                Console.WriteLine("New card is {0} of {1}", card3.Value, card3.Suit);
            }

            Console.Read();
        }
    }
}
