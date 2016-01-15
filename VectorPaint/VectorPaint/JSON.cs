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
        public void To(List<XData> bouncingBalls, string path)
        {
            string json = JsonConvert.SerializeObject(bouncingBalls.ToArray());
            File.WriteAllText(path, json);
        }

        public List<XData> From(string path)
        {
            StreamReader reader = new StreamReader(path);
            var list = reader.ReadToEnd();
            List<XData> obj = JsonConvert.DeserializeObject<List<XData>>(list);
            return obj;
        }
    }
}
