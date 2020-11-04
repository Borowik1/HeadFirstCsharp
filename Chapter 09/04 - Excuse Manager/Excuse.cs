
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Excuse_Manager_2._0
{
    class Excuse
    {
        public string Description { get; internal set; }
        public string Results { get; internal set; }
        public DateTime LastUsed { get; internal set; }
        public string ExcusePath { get; internal set; }

        public Excuse()
        {

        }

        public Excuse(string fileName)
        {
            OpenFile(fileName);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.excuse");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        internal void Save(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed);
            }
        }

        public void OpenFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }
    }
}
