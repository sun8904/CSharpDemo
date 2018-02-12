using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CodeSkill.Usage.IO
{
    public class ReadWriteXml : IReadWriter
    {
        [XmlElement("Count")]
        public int Times { get; set; }

        public DateTime DateTime { get; set; }

        public ReadWriteXml()
        {
            Times = 0;
            DateTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"times{Times}, datetime {DateTime}";
        }

        public void Load()
        {
            string FileDirectory = System.IO.Path.Combine(Environment.CurrentDirectory, this.GetType().ToString());
            if (!Directory.Exists(FileDirectory))
            {
                Directory.CreateDirectory(FileDirectory);
            }

            Stream stream = new FileStream(FileDirectory + "\\" + this.GetType() + ".xml", FileMode.OpenOrCreate);
            using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
            {
                try
                {
                    var reader = new XmlSerializer(typeof(ReadWriteXml));
                    var result = reader.Deserialize(streamReader) as ReadWriteXml;
                    this.Times = result.Times;
                    Console.WriteLine("read " + result);
                }
                catch (Exception)
                {
                    Console.WriteLine("read error");
                }
            }
            stream.Close();
        }

        public void Save()
        {
            string FileDirectory = System.IO.Path.Combine(Environment.CurrentDirectory, this.GetType().ToString());

            Stream stream = new FileStream(FileDirectory + "\\" + this.GetType() + ".xml", FileMode.Create);
            using (StreamWriter TextWriter = new StreamWriter(stream, Encoding.UTF8))
            {
                var reader = new XmlSerializer(typeof(ReadWriteXml));
                ++Times;
                DateTime = DateTime.Now;
                reader.Serialize(TextWriter, this);

                Console.WriteLine($"write times{Times},datetime {DateTime}");
            }
        }
    }
}