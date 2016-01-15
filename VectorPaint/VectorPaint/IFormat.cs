using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorPaint.Customs;

namespace VectorPaint
{
    public interface IFormat
    {
        void To(List<XData> bouncingBalls, string path);
        List<XData> From(string path);
    }
}
