using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiwi.Core
{
    public class GreaterThan : Prim<JSInt, JSBool>
    {
        public GreaterThan(Expr<JSInt> e1, Expr<JSInt> e2) : base(e1, e2)
        {
            
        }

        public override string ToScript()
        {
            return e1.ToScript() + " > " + e2.ToScript();
        }
    }
}