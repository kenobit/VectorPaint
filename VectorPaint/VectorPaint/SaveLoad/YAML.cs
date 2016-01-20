using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Yaml.Serialization;
using VectorPaint.Customs;

namespace VectorPaint
{
    class YAML : IFormat
    {
        public void To(List<XData> figures, string path)
        {
            StreamReader reader = new StreamReader(path);
            var serializer = new YamlSerializer();
            string yaml = serializer.Serialize(figures);
            File.WriteAllText(path, yaml);
        }

        public List<XData> From(string path)
        {
            var serializer = new YamlSerializer();
            StreamReader reader = new StreamReader(path);

            string yaml = reader.ReadToEnd();
            object obj = serializer.Deserialize(yaml)[0];
            return (obj as List<XData>);
        }
    }
}
