<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kayitol.aspx.cs" Inherits="DeneyBilim.kayitol" %>

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

                    <asp:Button ID="btnkayit" CssClass="btnkayit" Text="KAYIT OL" runat="server" />


                    <asp:Button ID="btngiris" CssClass="btngiris" Text="GİRİŞ YAP" runat="server" PostBackUrl="~/giris.aspx" />




                    <div class="arama-wrap">
                        <asp:TextBox ID="txtarama" CssClass="txtarama" runat="server" placeholder="Arama" />
                        <asp:Button ID="btnarama" CssClass="btnarama" Text="ara" runat="server" OnClick="btnarama_Click" />

                    </div>
                </header>
                <div class="banner"></div>

                <div class="sol-taraf">


                    <div class="icerik-deneyler">


                        <div class="kayitmenu">



                            <asp:Label ID="lblyildiz" runat="server" Text=" " ForeColor="Red"></asp:Label>



                            <asp:Label ID="lblyildiz2" runat="server" Text=" " ForeColor="Red"> </asp:Label>




                            <asp:Label ID="lblyildiz3" runat="server" Text=" " ForeColor="Red"></asp:Label>





                            <asp:Label ID="lblyildiz5" runat="server" Text=" " ForeColor="Red"></asp:Label>






                            <asp:Label ID="lblyildiz6" runat="server" Text=" " ForeColor="Red"></asp:Label>







                            <asp:Label ID="lblyildiz7" runat="server" Text=" " ForeColor="Red"></asp:Label>







                            <asp:Label ID="lblyildiz8" runat="server" Text=" " ForeColor="Red"></asp:Label>









                            <asp:Table ID="Table1" runat="server" Width="662px" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid" defaultbutton="hesapolustur">

                                <asp:TableRow>
                                    <asp:TableCell Width="100px">
                                        <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı:"></asp:Label></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="kuladtext" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Kullanıcı adı boş geçilmez." ControlToValidate="kuladtext" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <br />
                                    </asp:TableCell>

                                </asp:TableRow>




                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label ID="Label2" runat="server" Text="İsim:"></asp:Label></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="adtext" runat="server"></asp:TextBox>
                                        <br />
                                    </asp:TableCell>

                                </asp:TableRow>





                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label ID="Label3" runat="server" Text="Soyisim:"></asp:Label></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="soyadtext" runat="server"></asp:TextBox>
                                        <br />
                                    </asp:TableCell>

                                </asp:TableRow>






                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label ID="Label4" runat="server" Text="Mail Adresi:"></asp:Label></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="mailtext" runat="server" placeholder="bilimdeney@gmail.com" TextMode="Email"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Email kısmı boş geçilemez" ForeColor="Red" ControlToValidate="mailtext"></asp:RequiredFieldValidator>
                                        <br />
                                    </asp:TableCell>

                                </asp:TableRow>





                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label ID="Label5" runat="server" Text="Şifre:"></asp:Label></asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="sifretext" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Şifre Boş geçilmez" ControlToValidate="sifretext" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="şifreler uyuşmuyor" ControlToCompare="sifretekrartext" ControlToValidate="sifretext"></asp:CompareValidator>
                                        <asp:RegularExpressionValidator ID="requ1" runat="server" ControlToValidate="sifretext"
                                            ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$" ErrorMessage="Şifreniz en az 8-16 karakter 1 numara ve 1 harf içermeli" ForeColor="Red" />
                                        <br />
                                    </asp:TableCell></asp:TableRow><asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label ID="Label6" runat="server" Text="Şifre Tekrar:"></asp:Label></asp:TableCell><asp:TableCell>
                                            <asp:TextBox ID="sifretekrartext" runat="server" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Şifre tekrar Boş geçilmez" ControlToValidate="sifretekrartext" ForeColor="Red"></asp:RequiredFieldValidator>
                                            <br />
                                        </asp:TableCell></asp:TableRow><asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label ID="Label7" runat="server" Text="Doğum Tarihi:"></asp:Label></asp:TableCell><asp:TableCell>
                                            <asp:TextBox ID="dogtarihtext" runat="server" placeholder="11/11/1911" TextMode="Date"></asp:TextBox>
                                            <br />
                                        </asp:TableCell></asp:TableRow></asp:Table><br />

                            <asp:Label ID="lbl1" runat="server" Visible="False"></asp:Label><asp:Label ID="lbl2" runat="server" Visible="False"></asp:Label><asp:Table ID="Table2" runat="server" Width="662px" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid">
                                <asp:TableRow>
                                    <asp:TableHeaderCell>
                                        <asp:Button ID="hesapolustur" Text="Hesap Oluştur" runat="server" OnClick="hesapolustur_Click" BorderColor="Black" CausesValidation="true" defaultbutton="hesapolustur" />
                                        <asp:Label ID="lblsonuc" runat="server" ForeColor="Red"></asp:Label><br />
                                    </asp:TableHeaderCell></asp:TableRow></asp:Table></div></div></div><div class="sag-taraf">


                    <div class="haberler">
                        İÇERİKLER<br />
                        <asp:ImageButton CssClass="haber1" Text="haber1" runat="server" ID="Image1" OnClick="Image1_Click" Height="100px" Width="250px" />
                        <asp:Label ID="LabelImage1" runat="server" Visible="False"></asp:Label><br />
                        <asp:ImageButton CssClass="haber2" Text="haber2" runat="server" ID="Image2" OnClick="Image2_Click" />
                        <asp:Label ID="LabelImage2" runat="server" Visible="False"></asp:Label><br />
                        <asp:ImageButton CssClass="haber3" Text="haber3" runat="server" ID="Image3" OnClick="Image3_Click" />
                        <asp:Label ID="LabelImage3" runat="server" Visible="False"></asp:Label><br />

                    </div>


                </div>



            </div>
        </div>


        <footer>BilimDeney Bütün hakları saklıdır 2016.</footer><asp:Panel ID="kayitpanel" runat="server">
            <asp:SqlDataSource ID="SqlDataSource13" runat="server" connectionString="Data Source=DESKTOP-IGQ966L;Initial Catalog=BilimDeney;Integrated Security=True" SelectCommand="SELECT * FROM [uyeler]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource14" runat="server" connectionString="Data Source=DESKTOP-IGQ966L;Initial Catalog=BilimDeney;Integrated Security=True" SelectCommand="SELECT * FROM [icerik]"></asp:SqlDataSource>
        </asp:Panel>

    </form>
</body>
</html>
