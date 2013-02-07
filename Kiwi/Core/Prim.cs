using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiwi.Core
{
    public abstract class Prim<T, TResult> : Expr<TResult> where T : JSType where TResult : JSType
    {
        protected Expr<T> e1;
        protected Expr<T> e2;

        public Prim(Expr<T> e1, Expr<T> e2) {
            this.e1 = e1;
            this.e2 = e2;
        }
    }
}