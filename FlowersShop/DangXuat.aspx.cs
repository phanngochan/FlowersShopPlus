using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlowersShop
{
    public partial class DangXuat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Lưu URL của trang hiện tại vào Session
                Session["LastPageUrl"] = Request.UrlReferrer?.AbsoluteUri;

                // Hủy bỏ Session
                Session.Abandon();

                // Chuyển hướng đến trang chủ
                Response.Redirect("TrangChu.aspx");
            }
        }
    }
}