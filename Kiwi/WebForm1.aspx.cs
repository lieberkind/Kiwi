using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kiwi.Core;

namespace Kiwi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Plus p = new Plus(new ConstI(1), new ConstI(2));
            Response.Write(p.ToScript() + "<br>");

            GreaterThan gt = new GreaterThan(new ConstI(2), new ConstI(4));
            Response.Write(gt.ToScript() + "<br>");

            Plus p2 = new Plus(p, new ConstI(3));
            Response.Write(p2.ToScript() + "<br>");

            GreaterThan gt2 = new GreaterThan(p, p2);
            Response.Write(gt2.ToScript() + "<br>");

            LogicalAnd la = new LogicalAnd(gt, gt2);
            Response.Write(la.ToScript() + "<br>");

            If<JSBool> i = new If<JSBool>(gt2, gt, gt2);
            Response.Write(i.ToScript() + "<br>");
        }
    }
}