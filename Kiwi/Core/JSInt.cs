using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiwi.Core
{
    public class JSInt : JSType
    {
        int i;

        public JSInt(int i)
        {
            this.i = i;
        }

        public override string ToScript()
        {
            return i.ToString();
        }
    }
}