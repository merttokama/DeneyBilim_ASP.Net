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
    public partial class deneyler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object kullanici = Session["kullanıcı"];
            string str = Request.QueryString.Get("Ktg");

            if (str == null)
            {
                Label1.Text = "Kategori: Deneyler";
                SqlDataSource4.SelectCommand = "SELECT icerikid,icerikfotograf,icerikbaslik FROM icerik WHERE icerikturu LIKE '%Deney%' ORDER BY icerikzaman ASC";
            }
            else
            {
                SqlDataSource4.SelectCommand = "SELECT icerikid,icerikfotograf,icerikbaslik FROM icerik WHERE icerikturu LIKE '%" + str + "%' ORDER BY icerikzaman ASC";
                if (str == "Sosyal")
                {
                    Label1.Text = "Kategori: Sosyal Deneyler";
                }
                else if (str == "Ev")
                {
                    Label1.Text = "Kategori: Ev Yapımı Deneyler";
                }
                else if (str == "Fen")
                {
                    Label1.Text = "Kategori: Fen Deneyleri";
                }
                else if (str == "Eğlence")
                {
                    Label1.Text = "Kategori: Eğlenceli Deneyler";
                }
                else if (str == "Eğitsel")
                {
                    Label1.Text = "Kategori: Eğitsel Deneyler";
                }
                else if (str == "Psikoloji")
                {
                    Label1.Text = "Kategori: Psikoloji Deneyleri";
                }

            }



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

            SqlCommand db_komut = new SqlCommand("SELECT TOP 3 * FROM icerik WHERE icerikturu LIKE '%Deney%' ORDER BY NEWID()", db_baglanti);
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

        protected void btnarama_Click(object sender, EventArgs e)
        {
            Session.Add("ara", txtarama.Text);
            Response.Redirect("~/arama.aspx");
        }

        protected void Image3_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("icerik", LabelImage3.Text);
            Response.Redirect("~/icerikler.aspx");
        }
    }
}