using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;

namespace DeneyBilim
{
    public partial class profilonay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            meta.Content = "5;url=profil.aspx";
            this.Page.Controls.Add(meta);
            Label1.Text = "5 saniye sonra yönlendirileceksiniz.";

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
    }
}