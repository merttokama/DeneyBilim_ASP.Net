<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kayitonay.aspx.cs" Inherits="DeneyBilim.kayitonay" %>

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
      <a href="Default.aspx"> <img src="resimler/1giagx.gif" width="200" /></a>
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
           
            <asp:Button ID="btnkayit" CssClass="btnkayit" Text="KAYIT OL" runat="server"/>

            
            <asp:Button ID="btngiris" CssClass="btngiris" Text="GİRİŞ YAP" runat="server" PostBackUrl="~/giris.aspx"/>
          
            
            
            
            <div class="arama-wrap">
                <asp:TextBox ID="txtarama" CssClass="txtarama" runat="server" placeholder="Arama"/>
                <asp:Button ID="btnarama" CssClass="btnarama" text="ara" runat="server" OnClick="btnarama_Click" />

            </div>
        </header>
            <div class="banner"></div>
            
            <div class="sol-taraf">


            <div class="icerik-deneyler">

                Başarı ile kayıt oldunuz.<br />
                <asp:Label ID="Label1" runat="server"></asp:Label>

        </div>
                </div>
            


            <div class="sag-taraf">
                

          <div class="haberler">
                        İÇERİKLER<br />
                        <asp:ImageButton CssClass="haber1" Text="haber1" runat="server" ID="Image1" OnClick="Image1_Click" Height="100px" Width="250px" />
                        <asp:Label ID="LabelImage1" runat="server" Visible="False"></asp:Label>
                        <br />
                        <asp:ImageButton CssClass="haber2" Text="haber2" runat="server" ID="Image2" OnClick="Image2_Click" />
                        <asp:Label ID="LabelImage2" runat="server" Visible="False"></asp:Label>
                        <br />
                        <asp:ImageButton CssClass="haber3" Text="haber3" runat="server" ID="Image3" OnClick="Image3_Click" />
                        <asp:Label ID="LabelImage3" runat="server" Visible="False"></asp:Label>
                        <br />
 
         
                </div>
                

                </div>

            

            </div>
            </div>
       
            
            <footer>BilimDeney Bütün hakları saklıdır 2016.</footer>

        <asp:Panel ID="kayitpanel" runat="server">
            <asp:SqlDataSource ID="SqlDataSource15" runat="server" connectionString="Data Source=DESKTOP-IGQ966L;Initial Catalog=BilimDeney;Integrated Security=True" SelectCommand="SELECT * FROM [icerik]"></asp:SqlDataSource>
        </asp:Panel>

        </form>
</body>
</html>
