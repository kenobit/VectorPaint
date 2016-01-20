using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using VectorPaint.Customs;

namespace VectorPaint
{
    class Binnary : IFormat
    {
        public void To(List<XData> figures, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Create(path);
            using (var ms = new MemoryStream())
            {
                formatter.Serialize(file, figures);
                var bytes = ms.ToArray();
            }
            file.Close();
        }

        public List<XData> From(string path)
        {
            List<XData> list = new List<XData>();
            using (Stream file = File.Open(path, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                object obj = formatter.Deserialize(file);
                list = obj as List<XData>;
            }
            return list;
            //XmlSerializer serializer = new XmlSerializer(typeof(List<XData>));
            //StreamReader stringReader = new StreamReader(path);
            //List<XData> list = (List<XData>)serializer.Deserialize(stringReader);
            //return list;
        }
    }
}
