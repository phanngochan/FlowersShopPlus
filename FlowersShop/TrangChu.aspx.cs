using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlowersShop
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["LastPageUrl"] = Request.Url.AbsoluteUri;
            if ((string)Session["username"] == null)
            {
                var str = "<div class=\"icons\" id=\"icons\" runat=\"server\"> " +
                    " <a href=\"TimKiem.aspx\" class=\"fas fa-search\"></a> " +
                    " <a href=\"YeuThich.aspx\" class=\"fas fa-heart\"></a>  " +
                    " <a href=\"GioHang.aspx\" class=\"fas fa-shopping-cart\"></a>  " +
                    " <a href=\"DangNhap.aspx\" class=\"fas fa-user\"></a>";
                icons.InnerHtml = str;
                
            }
            
            else
            {
                /*var str = "<a>" + (string)Session["username"] + "</a>";

                username.InnerHtml = str;*/

                var str = "<div class=\"icons\" id=\"icons\" runat=\"server\">\r\n " +
                    "<a href=\"TimKiem.aspx\" class=\"fas fa-search\"></a>\r\n " +
                    "<a href=\"YeuThich.aspx\" class=\"fas fa-heart\"></a>\r\n  " +
                    "<a href=\"GioHang.aspx\" class=\"fas fa-shopping-cart\"></a>\r\n   " +
                    "<a href=\"\" class=\"fas fa-user\"></a>\r\n" +
                    "<a>" + (string)Session["username"] + "</a>" +
                    "<a href=\"DangXuat.aspx\" class=\"fas fa-sign-out\" ></a>";
                icons.InnerHtml = str;
            }

            List<Objects.products> products = (List<Objects.products>)Application["listProducts"];
            
            string html = "";
            foreach (Objects.products product in products)
            {
                html +=

                    " <div class=\"box\">" +
                        "<div class=\"image\">" +
                            "<a href='ChiTietSP.aspx?id=" + product.id + "'>" +
                            "<img src=\"" + product.image + "\" alt=\"\">" +
                            "</a>" +
                            "<div class=\"icons\">" +
                                "<a href='YeuThichThem.aspx?id="+ product.id  +"' class=\"fas fa-heart\"></a>" +
                                "<a href='ThemVaoGH.aspx?id="+ product.id  + "' class=\"cart-btn\">add to cart</a>" +
                                "<a href=\"#\" class=\"fas fa-share\"></a>" +
                            "</div>" +
                        "</div>" +
                        "<div class=\"content\">" +
                            "<h3>" + product.name + "</h3>" +
                            "<div class=\"price\">$" + product.price + "</div>" +
                        "</div>" +
                    "</div>";

            }
            listProducts.InnerHtml = html;
        }
    }
}