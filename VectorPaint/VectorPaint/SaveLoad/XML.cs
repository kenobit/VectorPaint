using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using VectorPaint.Customs;

namespace VectorPaint
{
    public class XML:IFormat
    {
        public void To(List<XData> figures, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<XData>));
            FileStream file = File.Create(path);
            xmlSerializer.Serialize(file, figures);
            file.Close();
        }

        public List<XData> From(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<XData>));
            StreamReader stringReader = new StreamReader(path);
            List<XData> list = (List<XData>)serializer.Deserialize(stringReader);
            return list;
        }
    }
}
