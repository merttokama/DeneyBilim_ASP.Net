<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DeneyBilim.Default" %>

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
                                                          <ul class="onli">
                                        <li class="sosyal"><a href="deneyler.aspx?Ktg=Sosyal">Sosyal Deneyler</a></li>
                                        <li class="evyapimi"><a href="deneyler.aspx?Ktg=Ev">Ev Yapımı Deneyler</a></li>
                                        <li class="fen"><a href="deneyler.aspx?Ktg=Fen">Fen Deneyleri</a></li>
                                        <li class="eglenceli"><a href="deneyler.aspx?Ktg=Eğlence">Eğlenceli Deneyler</a></li>
                                        <li class="egitsel"><a href="deneyler.aspx?Ktg=Eğitsel">Eğitsel Deneyler</a></li>
                                        <li class="psikoloji"><a href="deneyler.aspx?Ktg=Psikoloji">Psikoloji Deneyleri</a></li>
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
                        <asp:Button ID="btnarama" CssClass="btnarama" Text="ara" runat="server" PostBackUrl="~/arama.aspx" OnClick="btnarama_Click" />

                    </div>
                </header>
                <div class="banner"></div>



                <div class="sol-taraf">


                    <div class="icerik-deneyler">

                        <div class="ust">
                            <div>
                                <span>Rastgele İçerik Seçerek Sansımı Denemek İstiyorum.<br />

                                    <asp:ImageButton CssClass="rastgeleicerik1" ID="Image1" runat="server" OnClick="Image1_Click" />
                                    <asp:ImageButton CssClass="rastgeleicerik2" ID="Image2" runat="server" OnClick="Image2_Click" />
                                    <asp:ImageButton CssClass="rastgeleicerik3" ID="Image3" runat="server" OnClick="Image3_Click" />

                                </span>
                                <br />

                            </div>




                            Deneyler<br />
                            <asp:DataList ID="DataList1" runat="server" Font-Bold="True" HorizontalAlign="Left" RepeatColumns="1" DataKeyField="icerikid" DataSourceID="SqlDataSource1">
                                <ItemTemplate>
                                 <a href="icerikler.aspx?ID=<%# Eval("icerikid") %>">   <img src="kapakresimleri/<%# Eval("icerikfotograf") %>" height="100" style="width: 250px" /> </a>
                                    <a href="icerikler.aspx?ID=<%# Eval("icerikid") %>"><%# Eval("icerikbaslik") %> </a>
                                    <asp:Label ID="lblid" runat="server" Text='<%# Eval("icerikid") %>' Visible="False"></asp:Label>
                                    <br />

                                </ItemTemplate>

                            </asp:DataList>

                              <footer>BilimDeney Bütün hakları saklıdır 2016.</footer>
                        </div>
                    </div>
                </div>



                <div class="sag-taraf">


                    <div class="haberler">
                        HABERLER<br />
                        <asp:ImageButton CssClass="haber1" Text="haber1" runat="server" ID="ImageButton2" Height="100px" Width="250px" OnClick="ImageButton2_Click" />
                        <br />
                        <asp:ImageButton CssClass="haber2" Text="haber2" runat="server" ID="ImageButton3" OnClick="ImageButton3_Click" />
                        <br />
                        <asp:ImageButton CssClass="haber3" Text="haber3" runat="server" ID="ImageButton4" OnClick="ImageButton4_Click" />
                        <br />

                    </div>


                </div>



            </div>
        </div>


        <asp:Panel ID="kayitpanel" runat="server">
        </asp:Panel>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" connectionString="Data Source=DESKTOP-IGQ966L;Initial Catalog=BilimDeney;Integrated Security=True" SelectCommand="SELECT * FROM [icerik]"></asp:SqlDataSource>
        <asp:Label ID="LabelImage1" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="LabelImage2" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="LabelImage3" runat="server" Visible="False"></asp:Label>

        <asp:Label ID="LabelImage4" runat="server" Visible="False"></asp:Label>

        <asp:Label ID="LabelImage5" runat="server" Visible="False"></asp:Label>

        <asp:Label ID="LabelImage6" runat="server" Visible="False"></asp:Label>

    </form>
</body>
</html>
