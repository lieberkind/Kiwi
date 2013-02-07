using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiwi.Core
{
    public class IfStmt : Stmt
    {
        Expr<JSBool> cond;
        Stmt ifBranch;
        Stmt elseBranch;

        public IfStmt(Expr<JSBool> cond, Stmt ifBranch) {
            this.cond = cond;
            this.ifBranch = ifBranch;
        }

        public IfStmt(Expr<JSBool> cond, Stmt ifBranch, Stmt elseBranch)
        {
            this.cond = cond;
            this.ifBranch = ifBranch;
            this.elseBranch = elseBranch;
        }

        public override string ToScript()
        {
            return "";
        }
    }
}