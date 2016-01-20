using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorPaint.Customs;

namespace VectorPaint
{
    class JSON : IFormat
    {
        public void To(List<XData> figures, string path)
        {
            string json = JsonConvert.SerializeObject(figures.ToArray());
            File.WriteAllText(path, json);
        }

        public List<XData> From(string path)
        {
            StreamReader reader = new StreamReader(path);
            var list = reader.ReadToEnd();
            List<XData> figures = JsonConvert.DeserializeObject<List<XData>>(list);
            return figures;
        }
    }
}
