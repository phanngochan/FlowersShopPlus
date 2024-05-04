<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YeuThich.aspx.cs" Inherits="FlowersShop.YeuThich" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="FontsCss/fontawesome-free-6.5.2-web/css/all.min.css">
    <link rel="stylesheet" href="CSS/YeuThich.css">
    <title>Danh sách Yêu Thích</title>
</head>
<body runat="server">
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

        <div class="icons">
            <a href="TimKiem.aspx" class="fas fa-search"></a>
            <a href="YeuThich.aspx">
                <i class="fas fa-heart"></i>
                <span id="soluongyeuthich" runat="server" style="font-size: 70%;"></span>
            </a>
            <a href="#" class="fas fa-shopping-cart"></a>
            <a href="#" class="fas fa-user"></a>
        </div>
    </header>

    <section class="love">
        <div class="heading">
            <h1>DANH SACH SAN PHAM YEU THICH</h1>
        </div>
        <div class="container">
            <div class="shoppingCart" id="shoppingCart" runat="server">
                <div class="product__title">
                    <span class="product__title--name">Product</span>
                    <span class="product__title--price">Price</span>

                </div>

                <div class="product" id="cartBlock" runat="server">
                    <div class="shoppingCart__detail image">
                        <img src="anh/image8.jpg" alt="">
                    </div>
                    <div class="shoppingCart__detail name">
                        <h3>Carnation</h3>
                    </div>
                    <div class="shoppingCart__detail price">
                        <span id="price">$12.89</span>
                    </div>
                    <div class="shoppingCart__detail love">
                        <a href="#"><i class="fa-solid fa-heart"></i></a>
                    </div>
                    <div class="shoppingCart__detail remove">
                        <a href="#"><i class="fa-solid fa-xmark"></i></a>
                    </div>
                </div>


            </div>
        </div>
    </section>

    <section class="footer">
        <div class="box-container">
            <div class="box">
                <h3>quick links</h3>
                <a href="#">Home</a>
                <a href="#">about</a>
                <a href="#">products</a>
                <a href="#">review</a>
            </div>

            <div class="box">
                <h3>extra links</h3>
                <a href="#">my account</a>
                <a href="#">my order</a>
                <a href="#">my favorite</a>
            </div>

            <div class="box">
                <h3>locations </h3>
                <a href="#">Vietnam</a>
                <a href="#">USA</a>
                <a href="#">Germany</a>
            </div>

            <div class="box">
                <h3>contact info</h3>
                <a href="#">+74 123-321-345</a>
                <a href="#">flowershop@gmail.com</a>
                <a href="#">Hanoi, Vietnam - 12312</a>
            </div>
        </div>

        <div class="credit">created by <span>Phan Ngoc Han</span></div>
    </section>
</body>
</html>
