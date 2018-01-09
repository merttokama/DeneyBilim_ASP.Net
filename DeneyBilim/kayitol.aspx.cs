using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;

namespace DeneyBilim
{
    public partial class kayitol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object kullanici = Session["kullanıcı"];

            if (kullanici == null)
            {
                btngiris.Text = "GİRİŞ YAP";
                btngiris.PostBackUrl = "~/giris.aspx";

                btnkayit.Text = "KAYIT OL";
                btnkayit.PostBackUrl = "~/kayitol.aspx";
            }
            else
            {
                btngiris.Text = "ÇIKIŞ YAP";
                btngiris.PostBackUrl = "~/cıkıs.aspx";

                btnkayit.Text = "PROFİLİM";
                btnkayit.PostBackUrl = "~/profil.aspx";
            }

            string fotograf;

            SqlConnection db_baglanti = new SqlConnection
  (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
            db_baglanti.Open();

            SqlCommand db_komut = new SqlCommand("SELECT TOP 3 * FROM icerik ORDER BY NEWID()", db_baglanti);
            SqlDataReader alinan_veri;
            alinan_veri = db_komut.ExecuteReader();


            int rg = 1;

            while (alinan_veri.Read())
            {
                if (rg == 3)
                {
                    fotograf = alinan_veri["icerikfotograf"] + "";
                    Image1.ImageUrl = "~/kapakresimleri/" + fotograf;
                    LabelImage1.Text = alinan_veri["icerikid"] + "";
                    rg = 1;
                }
                else if (rg == 2)
                {
                    fotograf = alinan_veri["icerikfotograf"] + "";
                    Image2.ImageUrl = "~/kapakresimleri/" + fotograf;
                    LabelImage2.Text = alinan_veri["icerikid"] + "";
                    rg++;
                }
                else if (rg == 1)
                {
                    fotograf = alinan_veri["icerikfotograf"] + "";
                    Image3.ImageUrl = "~/kapakresimleri/" + fotograf;
                    LabelImage3.Text = alinan_veri["icerikid"] + "";
                    rg++;
                }
            }

            db_baglanti.Close();
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

        protected void btnarama_Click(object sender, EventArgs e)
        {
            Session.Add("ara", txtarama.Text);
            Response.Redirect("~/arama.aspx");
        }
        protected void hesapolustur_Click(object sender, EventArgs e)
        {
            int adminyetki;
            adminyetki = 0;

            string kullaniciadi, sifre, mail, ad, soyad, dogtarih;
            kullaniciadi = kuladtext.Text;
            sifre = sifretext.Text;
            mail = mailtext.Text;
            ad = adtext.Text;
            soyad = soyadtext.Text;
            dogtarih = dogtarihtext.Text;


            lbl1.Text = FormsAuthentication.HashPasswordForStoringInConfigFile(sifre, "SHA1");
            lbl2.Text = FormsAuthentication.HashPasswordForStoringInConfigFile(lbl1.Text, "MD5");


            SqlConnection db_baglanti = new SqlConnection
  (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
            db_baglanti.Open();

            SqlCommand db_komut;
            db_komut = new SqlCommand("insert into uyeler (kullaniciadi,sifre,mailadresi,isim,soyisim,dogumtarihi,yetki) values ('" + kullaniciadi + "','" + lbl2.Text + "','" + mail + "','" + ad + "','" + soyad + "','" + dogtarih + "','" + adminyetki + "')", db_baglanti);

            db_komut.ExecuteNonQuery();

            db_baglanti.Close();

            Response.Write("İşlem gerçekleştirildi.");
            Response.Redirect("~/kayitonay.aspx");
        }
    }
}