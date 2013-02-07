using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiwi.Core
{
    public class Plus : Prim<JSInt, JSInt>
    {
        public Plus(Expr<JSInt> e1, Expr<JSInt> e2) : base(e1, e2)
        {

        }

        public override string ToScript()
        {
            return e1.ToScript() + " + " +  e2.ToScript();
        }
    }
}