using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FlowersShop
{
    public partial class XoaGioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Objects.products> cart = (List<Objects.products>)Application["listSPMua"];
            string idCart = Request.QueryString["idRemove"];
            //idCart = idCart.Replace("%", " ");
            foreach (Objects.products i in cart.ToList())
            {
                if (idCart == i.id)
                {
                    cart.Remove(i);
                }
            }

            Application["listSPMua"] = cart;
            Response.Redirect("GioHang.aspx");
        }
    }
}