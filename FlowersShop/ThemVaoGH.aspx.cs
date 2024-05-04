using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlowersShop
{
    public partial class ThemVaoGH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if ((string)Session["username"] != null)
            {
                List<Objects.products> productSell = (List<Objects.products>)Application["listSPMua"];
                List<Objects.products> products = (List<Objects.products>)Application["listProducts"]; ;

                var trung = 0;
                foreach (Objects.products product in products)
                {
                    if (Request.QueryString["id"] == product.id)
                    {
                        foreach (Objects.products item in productSell)
                        {
                            if (item.id == product.id)
                            {
                                trung++;
                            }
                        }
                        if (trung == 0)
                        {

                            productSell.Add(product);
                        }
                    }
                }

                Application["listSPMua"] = productSell;
                Response.Redirect("GioHang.aspx");
            }
            else
            {
                Response.Redirect("DangNhap.aspx");
            }
        }
    }
}