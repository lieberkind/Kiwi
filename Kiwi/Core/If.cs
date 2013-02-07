using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiwi.Core
{
    public class If<TResult> : Expr<TResult> where TResult : JSType
    {
        Expr<JSBool> cond;
        Expr<TResult> e1;
        Expr<TResult> e2;

        public If(Expr<JSBool> cond, Expr<TResult> e1, Expr<TResult> e2)
        {
            this.cond = cond;
            this.e1 = e1;
            this.e2 = e2;
        }

        public override string ToScript()
        {
            return "(" + cond.ToScript() + ") ? (" + e1.ToScript() + ") : (" + e2.ToScript() + ");";
        }
    }
}