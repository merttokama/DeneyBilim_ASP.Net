using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
using System.ComponentModel;
using System.Collections;

namespace DeneyBilim
{
    public partial class icerikler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object icerik = Session["icerik"];
            object kullanici = Session["kullanıcı"];

            string str = Request.QueryString.Get("ID");

            if (str == null && icerik != null)
            {
                SqlDataSource11.SelectCommand = "SELECT * FROM yorumlar WHERE yorumyapilangonderi = '" + icerik + "' ORDER BY zaman ASC";

            }
            else if (str != null && icerik == null)
            {
                SqlDataSource11.SelectCommand = "SELECT * FROM yorumlar WHERE yorumyapilangonderi = '" + str + "' ORDER BY zaman ASC";
            }
            else
            {
                Response.Redirect("~/default.aspx");
            }



            if (kullanici == null)
            {
                btngiris.Text = "GİRİŞ YAP";
                btngiris.PostBackUrl = "~/giris.aspx";

                btnkayit.Text = "KAYIT OL";
                btnkayit.PostBackUrl = "~/kayitol.aspx";
                Button1.Enabled = false;
                Image5.ImageUrl = "~/resimler/user77.png";
                isim0.Text = "Ziyaretçi";
                isim0.Enabled = false;
            }
            else
            {
                btngiris.Text = "ÇIKIŞ YAP";
                btngiris.PostBackUrl = "~/cıkıs.aspx";

                btnkayit.Text = "PROFİLİM";
                btnkayit.PostBackUrl = "~/profil.aspx";
            }





            if (str != null && icerik == null)
            {
                SqlConnection db_baglanti = new SqlConnection
      (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                db_baglanti.Open();

                SqlCommand db_komut = new SqlCommand("SELECT * FROM icerik WHERE icerikid = '" + str + "'", db_baglanti);

                SqlDataReader alinan_veri;
                alinan_veri = db_komut.ExecuteReader();

                while (alinan_veri.Read())
                {
                    lblicerikid.Text = str;
                    isim.Text = alinan_veri["kullaniciadi"] + "";
                    lblicerikturu.Text = alinan_veri["icerikturu"] + "";
                    lblicerikbaslik.Text = alinan_veri["icerikbaslik"] + "";
                    lblicerikmetin.Text = alinan_veri["icerikmetin"] + "";
                    lblzaman.Text = alinan_veri["icerikzaman"] + "";

                }

                db_baglanti.Close();



            }
            else if (str == null && icerik != null)
            {
                SqlConnection db_baglanti = new SqlConnection
      (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                db_baglanti.Open();

                SqlCommand db_komut = new SqlCommand("SELECT * FROM icerik WHERE icerikid = '" + icerik + "'", db_baglanti);

                SqlDataReader alinan_veri;
                alinan_veri = db_komut.ExecuteReader();

                while (alinan_veri.Read())
                {
                    lblicerikid.Text = alinan_veri["icerikid"] + "";
                    isim.Text = alinan_veri["kullaniciadi"] + "";
                    lblicerikturu.Text = alinan_veri["icerikturu"] + "";
                    lblicerikbaslik.Text = alinan_veri["icerikbaslik"] + "";
                    lblicerikmetin.Text = alinan_veri["icerikmetin"] + "";
                    lblzaman.Text = alinan_veri["icerikzaman"] + "";
                }

                db_baglanti.Close();




            }

            SqlConnection db_baglanti0 = new SqlConnection
  (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
            db_baglanti0.Open();

            SqlCommand db_komut0 = new SqlCommand("SELECT * FROM uyeler WHERE kullaniciadi = '" + isim.Text + "'", db_baglanti0);

            SqlDataReader alinan_veri0;
            alinan_veri0 = db_komut0.ExecuteReader();

            while (alinan_veri0.Read())
            {
                string a;
                a = alinan_veri0["profilfoto"] + "";
                Image4.ImageUrl = "~/profilresimleri/" + a;
            }
            db_baglanti0.Close();

            int hbr = 1;

            string metin = lblicerikturu.Text;

            string kelime = "Deney";

            int konum = metin.IndexOf(kelime);

            if (konum == -1)

            {
                Labelbaslik.Text = "HABERLER";

                SqlConnection db_baglanti2 = new SqlConnection
      (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                db_baglanti2.Open();

                SqlCommand db_komut2 = new SqlCommand("SELECT TOP 3 * FROM icerik WHERE icerikturu LIKE '%Haber%' ORDER BY NEWID()", db_baglanti2);
                SqlDataReader alinan_veri2;
                alinan_veri2 = db_komut2.ExecuteReader();

                while (alinan_veri2.Read())
                {
                    if (hbr == 3)
                    {

                        string fotograf = alinan_veri2["icerikfotograf"] + "";
                        Image1.ID = alinan_veri2["icerikid"] + "";
                        Image1.ImageUrl = "~/kapakresimleri/" + fotograf;
                        hbr = 1;
                    }
                    else if (hbr == 2)
                    {

                        string fotograf = alinan_veri2["icerikfotograf"] + "";
                        Image2.ID = alinan_veri2["icerikid"] + "";
                        Image2.ImageUrl = "~/kapakresimleri/" + fotograf;
                        hbr++;
                    }
                    else if (hbr == 1)
                    {

                        string fotograf = alinan_veri2["icerikfotograf"] + "";
                        Image3.ID = alinan_veri2["icerikid"] + "";
                        Image3.ImageUrl = "~/kapakresimleri/" + fotograf;
                        hbr++;
                    }

                }
                db_baglanti2.Close();
            }


            else
            {
                Labelbaslik.Text = "DENEYLER";

                SqlConnection db_baglanti1 = new SqlConnection
      (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
                db_baglanti1.Open();

                SqlCommand db_komut1 = new SqlCommand("SELECT TOP 3 * FROM icerik WHERE icerikturu LIKE '%Deney%' ORDER BY NEWID()", db_baglanti1);
                SqlDataReader alinan_veri1;
                alinan_veri1 = db_komut1.ExecuteReader();

                while (alinan_veri1.Read())
                {
                    if (hbr == 3)
                    {

                        string fotograf = alinan_veri1["icerikfotograf"] + "";
                        LabelImage1.Text = alinan_veri1["icerikid"] + "";
                        Image1.ImageUrl = "~/kapakresimleri/" + fotograf;
                        hbr = 1;

                    }
                    else if (hbr == 2)
                    {

                        string fotograf = alinan_veri1["icerikfotograf"] + "";
                        LabelImage2.Text = alinan_veri1["icerikid"] + "";
                        Image2.ImageUrl = "~/kapakresimleri/" + fotograf;
                        hbr++;
                    }
                    else if (hbr == 1)
                    {

                        string fotograf = alinan_veri1["icerikfotograf"] + "";
                        LabelImage3.Text = alinan_veri1["icerikid"] + "";
                        Image3.ImageUrl = "~/kapakresimleri/" + fotograf;
                        hbr++;
                    }

                }
                db_baglanti1.Close();
            }


            SqlConnection db_baglanti3 = new SqlConnection
  (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
            db_baglanti3.Open();

            SqlCommand db_komut3 = new SqlCommand("SELECT * FROM uyeler WHERE kullaniciadi = '" + kullanici + "'", db_baglanti3);

            SqlDataReader alinan_veri3;
            alinan_veri3 = db_komut3.ExecuteReader();

            while (alinan_veri3.Read())
            {
                string b;
                b = alinan_veri3["profilfoto"] + "";
                isim0.Text = alinan_veri3["kullaniciadi"] + "";
                Image5.ImageUrl = "~/profilresimleri/" + b;
            }
            db_baglanti3.Close();
        }

        protected void btnarama_Click(object sender, EventArgs e)
        {
            Session.Add("ara", txtarama.Text);
            Response.Redirect("~/arama.aspx");
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

        protected void isim_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/profil.aspx?ID=" + isim.Text + "");
        }

        protected void isim0_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/profil.aspx?ID=" + isim0.Text + "");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            kullanicideneme.Text = Session["kullanıcı"].ToString();

            SqlConnection db_baglanti = new SqlConnection
  (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
            db_baglanti.Open();

            SqlCommand db_komut;
            db_komut = new SqlCommand("INSERT INTO yorumlar (yorumyapilangonderi, yorumyapankisi, metin) VALUES ('" + lblicerikid.Text + "','" + kullanicideneme.Text + "','" + TextBox1.Text + "')", db_baglanti);

            db_komut.ExecuteNonQuery();

            db_baglanti.Close();

            Response.Write("İşlem gerçekleştirildi.");
            Response.Redirect(Request.RawUrl);
        }
    }
}