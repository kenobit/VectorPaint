﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorPaint.Customs
{
    public abstract class IShape: Control
    {
        public virtual string GetType{ get;}
        public virtual void DrowDrag(int mouseX, int mouseY)
        {

        }
    }
}