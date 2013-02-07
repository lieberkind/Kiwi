using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiwi.Core
{
    public class JSBool : JSType
    {
        bool b;

        public JSBool(bool b)
        {
            this.b = b;
        }

        public override string ToScript()
        {
            return b.ToString();
        }
    }
}