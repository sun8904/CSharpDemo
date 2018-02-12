using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill.Usage.IO
{
    public class ReadWriteTxt : IReadWriter
    {
        public string FileDirectory { get; set; }
        public int Times { get; set; }
        public DateTime DateTime { get; set; }

        public ReadWriteTxt()
        {
            FileDirectory = System.IO.Path.Combine(Environment.CurrentDirectory, this.GetType().ToString());
            Times = 0;
            DateTime = DateTime.Now;
        }

        public void Load()
        {
            if (!Directory.Exists(FileDirectory))
            {
                Directory.CreateDirectory(FileDirectory);
            }
            Stream stream = new FileStream(FileDirectory + "\\" + this.GetType() + ".txt", FileMode.OpenOrCreate);
            using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
            {
                try
                {
                    Times = int.Parse(streamReader.ReadLine());
                    DateTime = DateTime.Parse(streamReader.ReadLine());
                    Console.WriteLine($"read times{Times},datetime {DateTime}");
                }
                catch (Exception)
                {
                    Console.WriteLine("error ");
                }
            }
            stream.Close();
        }

        public void Save()
        {
            Stream stream = new FileStream(FileDirectory + "\\" + this.GetType() + ".txt", FileMode.OpenOrCreate);
            using (StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8))
            {
                streamWriter.WriteLine(++Times);
                streamWriter.WriteLine(DateTime);
                Console.WriteLine($"write times{Times},datetime {DateTime}");
            }
        }
    }
}