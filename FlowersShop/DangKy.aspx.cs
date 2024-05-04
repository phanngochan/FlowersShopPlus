using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlowersShop
{
    public partial class DangKi : System.Web.UI.Page
    {
        List<Objects.User> listUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            listUser = (List<Objects.User>)Application["listUser"];
        }

        protected void btnRegister_onClick(object sender, EventArgs e)
        {
            string name = Request.Form["txtName"].Trim();
            string number = Request.Form["txtnumber"].Trim();
            string cccd = Request.Form["txtcccd"].Trim();
            string password = Request.Form["txtpassword"].Trim();

            bool check = true;


            foreach (Objects.User user in listUser)
            {
                if (user.number == number && user.cccd == cccd)
                {

                    error.InnerHtml = "ERROR:Đã tồn tại số điện thoại và căn cước công dân!";
                    txtnumber.Focus();
                    //Response.Write("<script>alert('Phone number existed!');</script>");
                    check = false;
                    break;
                }
                else if(user.number == number)
                {
                    error.InnerHtml = "ERROR:Đã tồn tại số điện thoại !";
                    txtnumber.Focus();
                    //Response.Write("<script>alert('Phone number existed!');</script>");
                    check = false;
                    break;
                }
                else if (user.cccd == cccd)
                {
                    error.InnerHtml = "ERROR:Đã tồn tại căn cước công dân !";
                    txtcccd.Focus();
                    //Response.Write("<script>alert('Phone number existed!');</script>");
                    check = false;
                    break;
                }
                else
                {
                    error.InnerHtml = "";
                }

            }
            if (check)
            {
                Objects.User newUser = new Objects.User(number, name, password, cccd);
                listUser.Add(newUser);
                Application["listUser"] = listUser;
                Response.Redirect("DangNhap.aspx");
            }
        }

    }
}