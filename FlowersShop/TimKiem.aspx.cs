using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlowersShop
{
    public partial class TimKiem : System.Web.UI.Page
    {
        List<Objects.products> products;
        protected void Page_Load(object sender, EventArgs e)
        {


            products = (List<Objects.products>)Application["listProducts"];

            var searchText = Request.QueryString["txtSearch"];
            string html = "";
            if(searchText != null)
            {
                foreach (Objects.products product in products)
                {
                    if (product.name.ToLower().Contains(searchText.ToLower()))
                    {

                    html +=

                        " <div class=\"box\">" +
                            "<div class=\"image\">" +
                                "<a href='ChiTietSP.aspx?id=" + product.id + "'>" +
                                "<img src=\"" + product.image + "\" alt=\"\">" +
                                "</a>" +
                                "<div class=\"icons\">" +
                                    "<a href='YeuThichThem.aspx?id=" + product.id + "' class=\"fas fa-heart\"></a>" +
                                    "<a href='ThemVaoGH.aspx?id=" + product.id + "' class=\"cart-btn\">add to cart</a>" +
                                    "<a href=\"#\" class=\"fas fa-share\"></a>" +
                                "</div>" +
                            "</div>" +
                            "<div class=\"content\">" +
                                "<h3>" + product.name + "</h3>" +
                                "<div class=\"price\">$" + product.price + "</div>" +
                            "</div>" +
                        "</div>";
                    }

                }
                
            }
            else
            {

            }

            listProducts.InnerHtml = html;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            listProducts.InnerHtml = "";

            // Chuyển hướng đến trang TimKiem.aspx với tham số truy vấn txtSearch
            string searchQuery = txtSearch.Value;
            Response.Redirect("TimKiem.aspx?txtSearch=" + searchQuery);

        }
    }
}