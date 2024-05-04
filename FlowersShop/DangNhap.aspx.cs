using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlowersShop
{
    public partial class DangNhap : System.Web.UI.Page
    {
        List<Objects.User> listUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            listUser = (List<Objects.User>)Application["listUser"];
            
        }

        protected void btnLogin_onclick(object sender, EventArgs e)
        {
            string number = Request.Form["txtnumber"];
            string password = Request.Form["txtpassword"];
            string userName = "";

            if (IsPostBack)
            {

                foreach (Objects.User user in listUser)
                {
                    if (user.number == number && user.password == password)
                    {
                        userName = user.username;
                    }                  
                    if (userName != "")
                    {
                        Session["number"] = number;
                        Session["username"] = userName;
                        if (Session["LastPageUrl"] != null)
                        {
                            string lastPageUrl = Session["LastPageUrl"].ToString();
                            Session.Remove("LastPageUrl"); // Xóa Session sau khi sử dụng
                            Response.Redirect(lastPageUrl);
                        }
                        else
                        {
                            Response.Redirect("TrangChu.aspx");
                        }

                    }
                    else
                    {
                        error.InnerHtml = "ERROR: Wrong phone number or password!";
                    }
                }
            }
        }
    }
}