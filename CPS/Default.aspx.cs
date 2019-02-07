using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPSDAL;
using Security.Classes.Bussines;
using Security.Classes.DAL;
using Security.DataModels;

namespace CPS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            SEG_USER myuser = new UserBL().GetUser(txbUsuario.Text, txbPassword.Text);
            if (myuser != null)
            {
                Session.Add("SessionUserId", myuser.USER_ID);
                Response.Redirect("DashBoard.aspx");
            }
            


            //SEG_USER User = new bluser().GetUsuario(txbUsuario.Text, txbPassword.Text);
            //if (User == null)
            //{
            //string.Format("{0}", "Usuario NO Existe!");
            //    return;

            //}
            //else
            //{
            //    // Cookie IDUsuario
            //    HttpCookie myCookieUserId = new HttpCookie("CookieUSerId", User.USER_ID.ToString());
            //    myCookieUserId.Expires = DateTime.MaxValue;
            //    Response.Cookies.Add(myCookieUserId);
            //    Response.Redirect("DashBoard.aspx");
            //}

        }
    }
}