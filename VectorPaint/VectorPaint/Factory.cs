using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorPaint.Customs;

namespace VectorPaint
{
    public class Factory
    {
        IFormat f;

        public void Format(string format)
        {
            switch (format)
            {
                case "XML":
                    f = new XML();
                    break;
                case "JSON":
                    f = new JSON();
                    break;
                case "CSV":
                    f = new CSV();
                    break;
                case "YAML":
                    f = new YAML();
                    break;
                default:
                    f = new XML();
                    break;
            }
        }

        public void To(List<XData> shapes, string path)
        {
            f.To(shapes, path);
        }

        public List<XData> From(string path)
        {
            return f.From(path);
        }
    }
}
}
