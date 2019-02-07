using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPS
{
    public partial class Cerrar_Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["v_usu_id"] = null;
            Session["v_per_codigo"] = null;
            Response.Redirect("default.aspx");
        }
    }
}