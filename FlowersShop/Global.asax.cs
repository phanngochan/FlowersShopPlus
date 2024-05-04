using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace FlowersShop
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            List<Objects.products> listProducts = new List<Objects.products>();
            listProducts.Add(new Objects.products("1", "Picture/image1.jpg", "Pink Tulip", 12.99));
            listProducts.Add(new Objects.products("2", "Picture/image2.jpg", "Mix Flowers", 13.69));
            listProducts.Add(new Objects.products("3", "Picture/image3.jpg", "Violet", 21.00));
            listProducts.Add(new Objects.products("4", "Picture/image4.jpg", "Mix Flowers", 15.99));
            listProducts.Add(new Objects.products("5", "Picture/image5.jpg", "Lan Flowers", 16.29));
            listProducts.Add(new Objects.products("6", "Picture/image6.jpg", "Lilac Flowers", 15.79));
            listProducts.Add(new Objects.products("7", "Picture/image7.jpg", "Pink Flowers", 12.39));
            listProducts.Add(new Objects.products("8", "Picture/image8.jpg", "Pink Flowers", 12.89));
            listProducts.Add(new Objects.products("9", "Picture/image9.jpg", "Mix Tulip", 14.50));
            listProducts.Add(new Objects.products("10", "Picture/image10.jpg", "Mix Flowers", 18.50));
            listProducts.Add(new Objects.products("11", "Picture/image11.jpg", "Mix Tulip", 14.50));
            listProducts.Add(new Objects.products("12", "Picture/image12.jpg", "Mix Flowers", 19.30));
            listProducts.Add(new Objects.products("13", "Picture/image13.jpg", "Mix Flowers", 14.90));
            listProducts.Add(new Objects.products("14", "Picture/image14.jpg", "Mix Flowers", 14.50));
            listProducts.Add(new Objects.products("15", "Picture/image15.jpg", "Mix Tulip", 17.59));
            listProducts.Add(new Objects.products("16", "Picture/image16.jpg", "Mix Tulip", 15.50));
            listProducts.Add(new Objects.products("17", "Picture/image17.jpg", "Mix Tulip", 10.50));
            listProducts.Add(new Objects.products("18", "Picture/image18.jpg", "Mix Tulip", 30.50));
            Application["listProducts"] = listProducts;



            List<Objects.User> listUser = new List<Objects.User>();
            listUser.Add(new Objects.User("0987654321", "Linh", "123456789","100001234567"));
            /*listUser.Add(new Objects.User("0123456789", "Han", "123456789"));*/
            Application["listUser"] = listUser;

            List<Objects.products> listSPMua = new List<Objects.products>();
            Application["listSPMua"] = listSPMua;

            List<Objects.products> listSPYeuThich = new List<Objects.products>();
            Application["listSPYeuThich"] = listSPYeuThich;

            List<Objects.products> listTimKiem = new List<Objects.products>();
            Application["listTimKiem"] = listTimKiem;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}