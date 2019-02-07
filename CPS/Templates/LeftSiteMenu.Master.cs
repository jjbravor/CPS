using Security.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPS.Templates
{
    public partial class LeftSiteMenu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionUserId"] == null)
            {
                return;
            }
            int userid = int.Parse(Session["SessionUserId"].ToString());

            mainTemplateMenu.Controls.Add(new System.Web.UI.LiteralControl(GetVerticalUserMenu(this, userid)));
        }
        private string GetUserMenu(int nivel, int userid)
        {
            StringBuilder menu = new StringBuilder("");
            try
            {
                using (var db = new DBSecurityEntities())
                {
                    var lstMen1u = (from resource in db.SEG_RESOURCE
                                    join resourceprofile in db.SEG_RESOURCEPROFILE on resource.RESOURCE_ID equals resourceprofile.RESOURCE_ID
                                    join profile in db.SEG_PROFILE on resourceprofile.PROFILE_ID equals profile.PROFILE_ID
                                    join userprofile in db.SEG_USERPROFILE on profile.PROFILE_ID equals userprofile.PROFILE_ID
                                    join user in db.SEG_USER on userprofile.USER_ID equals user.USER_ID
                                    where resource.RESOURCE_PARENTID.Equals(nivel)
                                    select resource);
                    var lstMenu = lstMen1u.ToList();
                    if (lstMenu.Count() > 0)
                    {
                        foreach (var opcion in lstMenu)
                        {
                            var nodos = db.SEG_RESOURCE.Where(y => y.RESOURCE_PARENTID == opcion.RESOURCE_ID).Count();
                            if (nodos > 0)
                            {
                                menu.Append("<li  >");
                                menu.Append("<a href='#' > " + opcion.RESOURCE_NOMBRE.ToUpper() + " <b class='caret'></b> </a>"); /*< b class='caret'></b> */
                                menu.Append(get_subitems(int.Parse(opcion.RESOURCE_ID.ToString().ToUpper()), userid));
                                menu.Append("</li>");
                            }
                            else
                            {
                                menu.Append("<li class='menu-item'><a href='" + opcion.RESOURCE_PAGE.ToUpper() + "'>" + opcion.RESOURCE_NOMBRE.ToUpper() + "</a></li>");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return menu.ToString();
        }



        public static string get_subitems(int idparent, int userid)
        {
            System.Text.StringBuilder submenu = new System.Text.StringBuilder("");
            using (var db = new DBSecurityEntities())
            {
                var query = (from resource in db.SEG_RESOURCE
                             join resourceprofile in db.SEG_RESOURCEPROFILE on resource.RESOURCE_ID equals resourceprofile.RESOURCE_ID
                             join profile in db.SEG_PROFILE on resourceprofile.PROFILE_ID equals profile.PROFILE_ID
                             join userprofile in db.SEG_USERPROFILE on profile.PROFILE_ID equals userprofile.PROFILE_ID
                             join user in db.SEG_USER on userprofile.USER_ID equals user.USER_ID
                             where resource.RESOURCE_PARENTID.Equals(idparent) && user.USER_ID.Equals(userid)
                             select resource);
                var itm = query.ToList();
                if (itm.Count > 0)
                {
                    submenu.Append("<ul class='nav' id='side-menu'>");
                    foreach (var sbitem in itm)
                    {
                        submenu.Append("<li>");
                        var link = string.Format("<a href='{0}'>{1}</a>", "uno", "unolink");

                        submenu.Append("</li>");
                    }
                    submenu.Append("</ul>");
                }

            }

            return submenu.ToString();
        }

        public static string GetVerticalUserMenu(Control control, int userid, int parentid = 0)
        {
            StringBuilder sbMenu = new StringBuilder("");
            try
            {
                using (var db = new DBSecurityEntities())
                {
                    var lstMen1u = (from resource in db.SEG_RESOURCE
                                    join resourceprofile in db.SEG_RESOURCEPROFILE on resource.RESOURCE_ID equals resourceprofile.RESOURCE_ID
                                    join profile in db.SEG_PROFILE on resourceprofile.PROFILE_ID equals profile.PROFILE_ID
                                    join userprofile in db.SEG_USERPROFILE on profile.PROFILE_ID equals userprofile.PROFILE_ID
                                    join user in db.SEG_USER on userprofile.USER_ID equals user.USER_ID
                                    where resource.RESOURCE_PARENTID.Equals(parentid)
                                    select resource);
                    var menuList = lstMen1u.ToList();
                    if (menuList.Count() > 0)
                    {

                        if (parentid == 0)
                            sbMenu.Append("<ul class='nav' id='side-menu'>");
                        else
                            sbMenu.Append("<ul class='nav nav-second-level'>");  


                        foreach (var item in menuList)
                        {
                            sbMenu.Append("<li>");

                            var link = string.Format("<a href='{0}'>{1}</a>", item.RESOURCE_PAGE, item.RESOURCE_NOMBRE.ToString().ToUpper());
                            var menuChildren = GetVerticalUserMenu(control, userid, (int)item.RESOURCE_ID);

                            sbMenu.Append(link);
                            sbMenu.Append(menuChildren);
                            sbMenu.Append("</li>");
                        }
                        sbMenu.Append("</ul>");
                        return sbMenu.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
            return sbMenu.ToString();
        }
    }
}