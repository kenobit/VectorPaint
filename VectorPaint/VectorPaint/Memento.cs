using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorPaint.Customs;

namespace VectorPaint
{
    public class Memento
    {
        private List<XData> list;

        public Memento(List<XData> list)
        {
            this.list = list;
        }

        public List<XData> GetState
        {
            get { return list; }
        }
    }
}
