using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace FlowersShop
{
    public partial class YeuThich : System.Web.UI.Page
    {
        List<Objects.products> listLoved;
        protected void Page_Load(object sender, EventArgs e)
        {
            listLoved = (List<Objects.products>)Application["listSPYeuThich"];

            string html = "";

            html +=
                "<div class='product__title'>"
                    + "<span class='product__title--name'>Product</span>"
                    + "<span class='product__title--price'>Price</span>"
            + "</div>";

            Session["soluongYeuThich"] = listLoved.Count;
            soluongyeuthich.InnerHtml = Session["soluongYeuThich"].ToString();

            for (int i = 0; i < listLoved.Count; i++)
            {

                html +=
                "<div class='product' id='cartBlock' runat='server'>"
                    + "<div class='shoppingCart__detail image'>"
                        + "<img src = '" + listLoved[i].image + "' alt=''>"
                    + "</div>"
                    + "<div class='shoppingCart__detail name'>"
                        + "<span>" + listLoved[i].name + "</span>"
                    + "</div>"

                    + "<div class='shoppingCart__detail price' >"
                        + "<span id='price'>$" + listLoved[i].price + " </span>"
                    + "</div>"
                    + "<div class=\"shoppingCart__detail love\"> "
                        + "<a href=\"#\"><i class=\"fa-solid fa-heart\"></i></a>"
                    + "</div>"
                    + "<div class='shoppingCart__detail remove'>"
                        + "<a href='XoaGioHang.aspx?idRemove=" + listLoved[i].id + "'><i class='fa-solid fa-xmark'></i></a>"
                    + "</div>"
                + "</div>";

            }

            shoppingCart.InnerHtml = html;
        }
    }
}