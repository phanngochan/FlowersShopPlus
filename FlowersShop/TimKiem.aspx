<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TimKiem.aspx.cs" Inherits="FlowersShop.TimKiem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="FontsCss/fontawesome-free-6.5.2-web/css/all.min.css">
    <link rel="stylesheet" href="CSS/TrangChu.css">
    <link rel="stylesheet" href="CSS/TimKiem.css">
    <title>Tim Kiem</title>
</head>
<body>
    <header>
        <input type="checkbox" name="" id="toggler">
        <label for="toggler" class="fas fa-bars"></label>

        <a href="TrangChu.aspx" class="logo">Flower<span>.</span></a>

        <nav class="navbar">
            <a href="TrangChu.aspx#home">Home</a>
            <a href="TrangChu.aspx#about">About</a>
            <a href="TrangChu.aspx#products">Products</a>
            <a href="TrangChu.aspx#review">Review</a>
        </nav>

        <div class="icons" id="icons" runat="server">
            <a href="TimKiem.aspx" class="fas fa-search"></a>
            <a href="YeuThich.aspx" class="fas fa-heart"></a>
            <a href="GioHang.aspx" class="fas fa-shopping-cart"></a>
            <a href="#" class="fas fa-user"></a>
        </div>
    </header>

    <form class="search" runat="server" method="post" >
    <div class="searchBar">
        <input placeholder="Search..." runat="server" id="txtSearch" name="txtSearch" type="text" required>
        <asp:Button class="btn" Text="SEARCH" runat="server" onclick="btnSearch_Click" />
    </div>   
   </form>

    <section class="products" id="products">
        
        <div class="box-container" id="listProducts" runat="server">

            <%--<div class="box">
            <div class="image">
                <a href='ChiTietSP.aspx?id=2'></a>
                <img src="/Picture/image1.jpg" alt=""/>
                <div class="icons">
                    <a href="#" class="fas fa-heart"></a>
                    <a href="#" class="cart-btn">add to cart</a>
                    <a href="#" class="fas fa-share"></a>
                </div>
            </div>
            <div class="content">
                <h3>flower pot</h3>
                <div class="price">$12.99</div>
            </div>
        </div>--%>
        </div>
    </section>
    <script>
    </script>
</body>
</html>
