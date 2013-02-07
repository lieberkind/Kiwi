using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiwi.Core
{
    public class LogicalAnd : Prim<JSBool, JSBool>
    {
        public LogicalAnd(Expr<JSBool> e1, Expr<JSBool> e2) : base(e1, e2)
        {

        }

        public override string ToScript()
        {
            return e1.ToScript() + " && " + e2.ToScript();
        }
    }
}