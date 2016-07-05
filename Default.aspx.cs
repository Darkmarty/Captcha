using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.UI;


namespace Captcha
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ResimOlustur();
            }
        }
        public void ResimOlustur()
        {
            string kod = "";
            kod = RastgeleVeriUret();
            Session.Add("kod", kod);
            Bitmap bmp = new Bitmap(100, 21);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawString(kod, new Font("Comic Sanns MS", 15), new SolidBrush(Color.Black),20,0);
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);
            var base64data = Convert.ToBase64String(ms.ToArray());
            imgKod.ImageUrl = "data:image/png;base64," + base64data;
            g.Dispose();
            bmp.Dispose();
            ms.Close();
            ms.Dispose();
        }
        public string RastgeleVeriUret()
        {
            string deger = "";
            string dizi = "ABCDEFGHIJKLMNOPRSTUVYZ0123456789";
            Random r = new Random();
            for (int i = 0; i < 5; i++) 
            {
                deger = deger + dizi[r.Next(0, 33)];
            }
            return deger;
        }

        protected void btnKontrol_Click(object sender, EventArgs e)
        {
            if (txtkontrolKodu.Text == Session["kod"].ToString()) 
            {
                lblMesaj.Text = "Dogrulama Saglandı";
            }
            else
            {
                lblMesaj.Text = "Dogrulama Kodu Yanlıs";
                ResimOlustur();
            }
          
        }
    }
}
