using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Data;


namespace DeneyBilim
{
    public partial class profil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string foto = "";
            object kullanici = Session["kullanıcı"];

            string str = Request.QueryString.Get("ID");

            if (kullanici == null)
            {
                btngiris.Text = "GİRİŞ YAP";
                btngiris.PostBackUrl = "~/giris.aspx";

                btnkayit.Text = "KAYIT OL";
                btnkayit.PostBackUrl = "~/kayitol.aspx";

                if (str == null)
                {
                    Response.Redirect("~/giris.aspx");
                }
                else
                {
                    BtnGuncelle.Visible = false;
                    btnsil.Visible = false;
                    btnEkle.Visible = false;
                    fuResim.Visible = false;

                    SqlConnection db_baglanti = new SqlConnection
          (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                    db_baglanti.Open();

                    SqlCommand db_komut = new SqlCommand("SELECT * FROM uyeler WHERE kullaniciadi = '" + str + "'", db_baglanti);

                    SqlDataReader alinan_veri;
                    alinan_veri = db_komut.ExecuteReader();

                    while (alinan_veri.Read())
                    {
                        lblkullaniciadi.Text = alinan_veri["kullaniciadi"] + "";
                        lblisim.Text = alinan_veri["isim"] + "";
                        lblsoyisim.Text = alinan_veri["soyisim"] + "";
                        lblmail.Text = alinan_veri["mailadresi"] + "";
                        lbldogtarih.Text = alinan_veri["dogumtarihi"] + "";
                        lblhobiler.Text = alinan_veri["hobiler"] + "";
                        foto = alinan_veri["profilfoto"] + "";

                    }

                    Image1.ImageUrl = "~/profilresimleri/" + foto;

                    db_baglanti.Close();





                }
            }
            else if (kullanici != null && str != null && kullanici.ToString() == str)
            {
                btngiris.Text = "ÇIKIŞ YAP";
                btngiris.PostBackUrl = "~/cıkıs.aspx";

                btnkayit.Text = "PROFİLİM";
                btnkayit.PostBackUrl = "~/profil.aspx";



                SqlConnection db_baglanti = new SqlConnection
      (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                db_baglanti.Open();

                SqlCommand db_komut = new SqlCommand("SELECT * FROM uyeler WHERE kullaniciadi = '" + kullanici + "'", db_baglanti);

                SqlDataReader alinan_veri;
                alinan_veri = db_komut.ExecuteReader();

                while (alinan_veri.Read())
                {
                    lblkullaniciadi.Text = alinan_veri["kullaniciadi"] + " ";
                    lblisim.Text = alinan_veri["isim"] + " ";
                    lblsoyisim.Text = alinan_veri["soyisim"] + " ";
                    lblmail.Text = alinan_veri["mailadresi"] + " ";
                    lbldogtarih.Text = alinan_veri["dogumtarihi"] + " ";
                    lblhobiler.Text = alinan_veri["hobiler"] + " ";
                    foto = alinan_veri["profilfoto"] + " ";

                }

                Image1.ImageUrl = "~/profilresimleri/" + foto;

                db_baglanti.Close();

            }

            else if (kullanici != null && str != null && kullanici.ToString() != str)

            {

                btngiris.Text = "ÇIKIŞ YAP";
                btngiris.PostBackUrl = "~/cıkıs.aspx";

                btnkayit.Text = "PROFİLİM";
                btnkayit.PostBackUrl = "~/profil.aspx";

                BtnGuncelle.Visible = false;
                btnsil.Visible = false;
                btnEkle.Visible = false;
                fuResim.Visible = false;

                SqlConnection db_baglanti = new SqlConnection
      (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                db_baglanti.Open();

                SqlCommand db_komut = new SqlCommand("SELECT * FROM uyeler WHERE kullaniciadi = '" + str + "'", db_baglanti);

                SqlDataReader alinan_veri;
                alinan_veri = db_komut.ExecuteReader();

                while (alinan_veri.Read())
                {
                    lblkullaniciadi.Text = alinan_veri["kullaniciadi"] + " ";
                    lblisim.Text = alinan_veri["isim"] + " ";
                    lblsoyisim.Text = alinan_veri["soyisim"] + " ";
                    lblmail.Text = alinan_veri["mailadresi"] + " ";
                    lbldogtarih.Text = alinan_veri["dogumtarihi"] + " ";
                    lblhobiler.Text = alinan_veri["hobiler"] + " ";
                    foto = alinan_veri["profilfoto"] + " ";

                }

                Image1.ImageUrl = "~/profilresimleri/" + foto;

                db_baglanti.Close();

            }

            else if (kullanici != null && str == null)
            {


                btngiris.Text = "ÇIKIŞ YAP";
                btngiris.PostBackUrl = "~/cıkıs.aspx";

                btnkayit.Text = "PROFİLİM";
                btnkayit.PostBackUrl = "~/profil.aspx";



                SqlConnection db_baglanti = new SqlConnection
      (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                db_baglanti.Open();

                SqlCommand db_komut = new SqlCommand("SELECT * FROM uyeler WHERE kullaniciadi = '" + kullanici + "'", db_baglanti);

                SqlDataReader alinan_veri;
                alinan_veri = db_komut.ExecuteReader();

                while (alinan_veri.Read())
                {
                    lblkullaniciadi.Text = alinan_veri["kullaniciadi"] + " ";
                    lblisim.Text = alinan_veri["isim"] + " ";
                    lblsoyisim.Text = alinan_veri["soyisim"] + " ";
                    lblmail.Text = alinan_veri["mailadresi"] + " ";
                    lbldogtarih.Text = alinan_veri["dogumtarihi"] + " ";
                    lblhobiler.Text = alinan_veri["hobiler"] + " ";
                    foto = alinan_veri["profilfoto"] + " ";

                }

                Image1.ImageUrl = "~/profilresimleri/" + foto;

                db_baglanti.Close();


            }

            string fotograf;

            SqlConnection db_baglanti0 = new SqlConnection
  (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
            db_baglanti0.Open();

            SqlCommand db_komut0 = new SqlCommand("SELECT TOP 3 * FROM icerik ORDER BY NEWID()", db_baglanti0);
            SqlDataReader alinan_veri0;
            alinan_veri0 = db_komut0.ExecuteReader();


            int rg = 1;

            while (alinan_veri0.Read())
            {
                if (rg == 3)
                {
                    fotograf = alinan_veri0["icerikfotograf"] + "";
                    Image11.ImageUrl = "~/kapakresimleri/" + fotograf;
                    LabelImage1.Text = alinan_veri0["icerikid"] + "";
                    rg = 1;
                }
                else if (rg == 2)
                {
                    fotograf = alinan_veri0["icerikfotograf"] + "";
                    Image2.ImageUrl = "~/kapakresimleri/" + fotograf;
                    LabelImage2.Text = alinan_veri0["icerikid"] + "";
                    rg++;
                }
                else if (rg == 1)
                {
                    fotograf = alinan_veri0["icerikfotograf"] + "";
                    Image3.ImageUrl = "~/kapakresimleri/" + fotograf;
                    LabelImage3.Text = alinan_veri0["icerikid"] + "";
                    rg++;
                }
            }

            db_baglanti0.Close();
        }

        protected void Image1_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("icerik", LabelImage1.Text);
            Response.Redirect("~/icerikler.aspx");
        }

        protected void Image2_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("icerik", LabelImage2.Text);
            Response.Redirect("~/icerikler.aspx");
        }

        protected void Image3_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("icerik", LabelImage3.Text);
            Response.Redirect("~/icerikler.aspx");
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            BtnGuncelle.Visible = false;
            lblisim.Visible = false;
            lblsoyisim.Visible = false;
            lbldogtarih.Visible = false;
            lblhobiler.Visible = false;

            btnkaydet.Visible = true;
            txtisim.Visible = true;
            txtsoyisim.Visible = true;
            txtdogtarih.Visible = true;
            txthobi.Visible = true;
        }

        protected void btnkaydet_Click(object sender, EventArgs e)
        {
            object kullanici = Session["kullanıcı"];
            if (lblisim.Text == null || lblsoyisim.Text == null || lbldogtarih.Text == null || lblhobiler.Text == null)
            {

                SqlConnection db_baglanti4 = new SqlConnection
      (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                db_baglanti4.Open();

                SqlCommand db_komut4;
                db_komut4 = new SqlCommand("Update uyeler SET isim = NULL, soyisim = NULL, hobiler = NULL, dogumtarihi = NULL WHERE kullaniciadi = '" + kullanici + "'", db_baglanti4);

                int gun_kay_say1 = db_komut4.ExecuteNonQuery();

                db_baglanti4.Close();


                SqlConnection db_baglanti = new SqlConnection
      (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                db_baglanti.Open();

                SqlCommand db_komut;
                db_komut = new SqlCommand("insert into uyeler (isim,soyisim,hobiler,dogumtarihi) values ('" + txtisim.Text + "','" + txtsoyisim.Text + "','" + txthobi.Text + "','" + txtdogtarih.Text + "')", db_baglanti);

                db_komut.ExecuteNonQuery();

                db_baglanti.Close();

                Response.Write("İşlem gerçekleştirildi.");
                Response.Redirect("~/profilonay.aspx");


            }
            else if (lblisim.Text != null && lblsoyisim.Text != null && lbldogtarih.Text != null && lblhobiler.Text != null)
            {


                SqlConnection db_baglanti2 = new SqlConnection
      (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                db_baglanti2.Open();

                SqlCommand db_komut2;
                db_komut2 = new SqlCommand("Update uyeler SET hobiler = '" + txthobi.Text + "', dogumtarihi = '" + txtdogtarih.Text + "', isim = '" + txtisim.Text + "', soyisim = '" + txtsoyisim.Text + "' WHERE kullaniciadi = '" + kullanici + "'", db_baglanti2);

                int gun_kay_say = db_komut2.ExecuteNonQuery();

                db_baglanti2.Close();

                Response.Write("İşleminiz Başarı İle Gerçekleşti");
                Response.Redirect("~/profilonay.aspx");
            }
        }

        protected void btnsil_Click(object sender, EventArgs e)
        {
            object kullanici = Session["kullanıcı"];


            SqlConnection db_baglanti3 = new SqlConnection
  (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
            db_baglanti3.Open();

            SqlCommand db_komut3;
            db_komut3 = new SqlCommand("Update uyeler SET profilfoto = NULL WHERE kullaniciadi = '" + kullanici + "'", db_baglanti3);

            int gun_kay_say = db_komut3.ExecuteNonQuery();

            db_baglanti3.Close();

            Response.Write("Profil Fotoğrafı Silme İşleminiz Başarı İle Gerçekleşti");
            Response.Redirect("~/profilonay.aspx");
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            object kullanici = Session["kullanıcı"];

            string uzanti = "";
            string resimadi = "";

            if (fuResim.HasFile)
            {
                uzanti = Path.GetExtension(fuResim.PostedFile.FileName);
                resimadi = "_profilresmi_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + uzanti;
                fuResim.SaveAs(Server.MapPath("~/profilresimleri/sahte" + uzanti));

                int Donusturme = 640;

                Bitmap bmp = new Bitmap(Server.MapPath("~/profilresimleri/sahte" + uzanti));
                using (Bitmap OrjinalResim = bmp)
                {
                    double ResYukseklik = OrjinalResim.Height;
                    double ResGenislik = OrjinalResim.Width;
                    double oran = 0;

                    if (ResGenislik >= Donusturme)
                    {
                        oran = ResGenislik / ResYukseklik;
                        ResGenislik = Donusturme;
                        ResYukseklik = Donusturme / oran;

                        Size yenidegerler = new Size(Convert.ToInt32(ResGenislik), Convert.ToInt32(ResYukseklik));
                        Bitmap yeniresim = new Bitmap(OrjinalResim, yenidegerler);
                        yeniresim.Save(Server.MapPath("~/profilresimleri/" + resimadi));

                        yeniresim.Dispose();
                        OrjinalResim.Dispose();
                        bmp.Dispose();


                    }
                    else
                    {
                        fuResim.SaveAs(Server.MapPath("~/profilresimleri/" + resimadi));
                    }
                }
                FileInfo figecici = new FileInfo(Server.MapPath("~/profilresimleri/sahte" + uzanti));
                figecici.Delete();


            }
            SqlConnection db_baglanti4 = new SqlConnection
  (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
            db_baglanti4.Open();

            SqlCommand db_komut4;
            db_komut4 = new SqlCommand("Update uyeler SET profilfoto = '" + resimadi + "' WHERE kullaniciadi = '" + kullanici + "'", db_baglanti4);

            int gun_kay_say = db_komut4.ExecuteNonQuery();

            db_baglanti4.Close();

            Response.Redirect("~/profil.aspx");
        }

        protected void btnarama_Click(object sender, EventArgs e)
        {
            Session.Add("ara", txtarama.Text);
            Response.Redirect("~/arama.aspx");
        }

        protected void btnkayit_Click(object sender, EventArgs e)
        {
            object kullanici = Session["kullanıcı"];
            object tikprofil = Session["tikprofil"];

            if (tikprofil == null && kullanici != null)
            {
                Response.Redirect("~/profil.aspx");
            }
            else if (tikprofil == null && kullanici == null)
            {
                Response.Redirect("~/kayitol.aspx");
            }
            else if (tikprofil != null && kullanici == null)
            {
                Session.Abandon();
                Session.Timeout = 120;
                Session.Add("kullanıcı", kullanici);
                Response.Redirect("~/kayitol.aspx");
            }
            else if (tikprofil != null && kullanici != null)
            {
                Session.Abandon();
                Session.Timeout = 120;
                Session.Add("kullanıcı", kullanici);
                Response.Redirect("~/profil.aspx");
            }
        }
    }
}