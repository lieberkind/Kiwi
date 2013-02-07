using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiwi.Core
{
    public class Const : Expr<JSType>
    {
        JSType constant;

        public Const(JSType constant)
        {
            this.constant = constant;
        }

        public override string ToScript()
        {
            return constant.ToScript();
        }
    }
}