using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiwi.Core
{
    public class ConstI : Expr<JSInt>
    {
        int i;

        public ConstI(int i)
        {
            this.i = i;
        }

        public override string ToScript()
        {
            return i.ToString();
        }
    }
}