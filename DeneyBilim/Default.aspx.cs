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
    public partial class Default : System.Web.UI.Page
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
            int rg = 1, hbr = 1;


            SqlConnection db_baglanti0 = new SqlConnection
(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);

            db_baglanti0.Open();

            SqlCommand db_komut0 = new SqlCommand("SELECT TOP 3 * FROM icerik ORDER BY NEWID()", db_baglanti0);
            SqlDataReader alinan_veri0;
            alinan_veri0 = db_komut0.ExecuteReader();


            while (alinan_veri0.Read())
            {
                if (rg == 3)
                {
                    LabelImage1.Text = alinan_veri0["icerikid"] + "";
                    Image1.ImageUrl = "~/resimler/Başlıksız-1.jpg";

                    rg = 1;
                }
                else if (rg == 2)
                {
                    LabelImage2.Text = alinan_veri0["icerikid"] + "";
                    Image2.ImageUrl = "~/resimler/Başlıksız-2.jpg";

                    rg++;
                }
                else if (rg == 1)
                {
                    LabelImage3.Text = alinan_veri0["icerikid"] + "";
                    Image3.ImageUrl = "~/resimler/Başlıksız-3.jpg";

                    rg++;
                }
                else
                {

                }

            }
            db_baglanti0.Close();





            SqlConnection db_baglanti1 = new SqlConnection
  (System.Web.Configuration.WebConfigurationManager.ConnectionStrings["veritabani"].ConnectionString);
            db_baglanti1.Open();

            SqlCommand db_komut1 = new SqlCommand("SELECT TOP 3 * FROM icerik WHERE icerikturu LIKE '%Haber%' ORDER BY NEWID()", db_baglanti1);
            SqlDataReader alinan_veri1;
            alinan_veri1 = db_komut1.ExecuteReader();

            while (alinan_veri1.Read())
            {
                if (hbr == 3)
                {
                    fotograf = alinan_veri1["icerikfotograf"] + "";
                    LabelImage4.Text = alinan_veri1["icerikid"] + "";
                    ImageButton2.ImageUrl = "~/kapakresimleri/" + fotograf;
                    hbr = 1;
                }
                else if (hbr == 2)
                {
                    fotograf = alinan_veri1["icerikfotograf"] + "";
                    LabelImage5.Text = alinan_veri1["icerikid"] + "";
                    ImageButton3.ImageUrl = "~/kapakresimleri/" + fotograf;
                    hbr++;
                }
                else if (hbr == 1)
                {
                    fotograf = alinan_veri1["icerikfotograf"] + "";
                    LabelImage6.Text = alinan_veri1["icerikid"] + "";
                    ImageButton4.ImageUrl = "~/kapakresimleri/" + fotograf;
                    hbr++;
                }
                else
                {

                }

            }
            db_baglanti1.Close();


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

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("icerik", LabelImage4.Text);
            Response.Redirect("~/icerikler.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("icerik", LabelImage5.Text);
            Response.Redirect("~/icerikler.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("icerik", LabelImage6.Text);
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
    }
}
