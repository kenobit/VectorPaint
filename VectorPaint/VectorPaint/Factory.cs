using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorPaint.Customs;

namespace VectorPaint
{
    class Factory
    {
        IFormat f;

        public void Format(string format)
        {
            switch (format)
            {
                case "XML":
                    f = new XML();
                    break;
                case "DAT":
                    f = new Binnary();
                    break;
                //case "JSON":
                //    f = new JSON();
                //    break;
                //case "YAML":
                //    f = new YAML();
                //    break;
                default:
                    f = new XML();
                    break;
            }
        }

        public void To(List<XData> figures, string path)
        {
            f.To(figures, path);
        }

        public List<XData> From(string path)
        {
            return f.From(path);
        }
    }
}
