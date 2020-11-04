using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01___Clones
{
    [Serializable]

    class Clone : IDisposable
    {
        public int Id { get; private set; }

        public Clone(int Id)
        {
            this.Id = Id;
        }

        public void Dispose()
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString() + @"\temp\Clone.dat";
            string dirname = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString() + @"\temp";

            if (File.Exists(fileName) == false)
            {
                Directory.CreateDirectory(dirname);
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream output = File.OpenWrite(fileName))
            {
                formatter.Serialize(output, this);
            }

            MessageBox.Show("Need... serialize... object...", "Clone #" + Id + " says");
        }
        ~Clone()
        {
            MessageBox.Show("Aaargh! You got me!", "Clone #" + Id + " says...");
        }
    }
}
