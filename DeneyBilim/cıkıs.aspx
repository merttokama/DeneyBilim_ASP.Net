<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cıkıs.aspx.cs" Inherits="DeneyBilim.cıkıs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>BilimDeney</title>
    <link href="/StyleSheet1.css" rel="stylesheet" />
    <script src="http://code.jquery.com/jquery-2.0.3.min.js"></script>
    <script type="text/javascript">

        $("document").ready(function () {
            $("header nav ul li.deneyler-wrap").mouseover(function () {
                $("header nav ul li.deneyler-wrap .deneyler").css("display", "block")

            })
            $("header nav ul li.deneyler-wrap").mouseleave(function () {
                $("header nav ul li.deneyler-wrap .deneyler").css("display", "none")

            })
        })

    </script>

   
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="ekran">
            
        <header>
        <div class="logo">
       <a href="BilimDeneyWebForm.aspx"> <img src="resimler/1giagx.gif" width="200" /></a>
            </div>
            <nav>
                <ul>
                    <li>
                        <a href="haberler.aspx">HABERLER</a>
                    </li>
                    <li class="deneyler-wrap">
                        <a href="deneyler.aspx">DENEYLER</a>
                        <div class="deneyler">
                                                                                     <ul>
                                        <li><a href="deneyler.aspx?Ktg=Sosyal">Sosyal Deneyler</a></li>
                                        <li><a href="deneyler.aspx?Ktg=Ev">Ev Yapımı Deneyler</a></li>
                                        <li><a href="deneyler.aspx?Ktg=Fen">Fen Deneyleri</a></li>
                                        <li><a href="deneyler.aspx?Ktg=Eğlence">Eğlenceli Deneyler</a></li>
                                        <li><a href="deneyler.aspx?Ktg=Eğitsel">Eğitsel Deneyler</a></li>
                                        <li><a href="deneyler.aspx?Ktg=Psikoloji">Psikoloji Deneyleri</a></li>
                                    </ul>
                        </div>
                     
                    </li>
                    <li>
                        <a href="hakkimizda.aspx">HAKKIMIZDA</a>
                    </li>
                    <li>
                        <a href="iletisim.aspx">İLETİŞİM</a>
                    </li>
                  
                </ul>
            </nav>
           
            <asp:Button ID="btnkayit" CssClass="btnkayit" Text="KAYIT OL" runat="server" />

            
            <asp:Button ID="btngiris" CssClass="btngiris" Text="GİRİŞ YAP" runat="server" PostBackUrl="~/giris.aspx"/>
          
            
            
            
            <div class="arama-wrap">
                <asp:TextBox ID="txtarama" CssClass="txtarama" runat="server" placeholder="Arama"/>
                <asp:Button ID="btnarama" CssClass="btnarama" text="ara" runat="server" />

            </div>
        </header>
            <div class="banner"></div>
            
            <div class="sol-taraf">


            <div class="icerik-deneyler">

                Güle Güle...</div>
                </div>
            


            <div class="sag-taraf">
                

           <div class="haberler">
                        İÇERİKLER<br />
                        <asp:ImageButton CssClass="haber1" Text="haber1" runat="server" ID="Image1" Height="100px" Width="250px" />
                        <asp:Label ID="LabelImage1" runat="server" Visible="False"></asp:Label>
                        <br />
                        <asp:ImageButton CssClass="haber2" Text="haber2" runat="server" ID="Image2" />
                        <asp:Label ID="LabelImage2" runat="server" Visible="False"></asp:Label>
                        <br />
                        <asp:ImageButton CssClass="haber3" Text="haber3" runat="server" ID="Image3" />
                        <asp:Label ID="LabelImage3" runat="server" Visible="False"></asp:Label>
                        <br />
         
                </div>
                

                </div>

              <footer>BilimDeney Bütün hakları saklıdır 2016.</footer>

            </div>
            </div>
       
       
        <asp:Panel ID="kayitpanel" runat="server">
        </asp:Panel>

        </form>
</body>
</html>
