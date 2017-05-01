using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rnapos
{
    public partial class frmMain : Form
    {
        /* var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://kanlazimapp.com/smartbright/test.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"test\":\"denemek\"," +
                              "\"password\":\"bla\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                MessageBox.Show(result.ToString());
            }
        */
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            lblTime.Text=DateTime.Now.ToString("MM-dd-yyyy hh:mm",CultureInfo.CreateSpecificCulture("tr-TR"));
            Color color = Color.FromArgb(241, 132, 16);
            tileControl1.BackColor = color;
            this.BackColor = color;
            lblName.BackColor = color;
            lblTime.BackColor = color;
            //F1C410
        }

        private void tileExit_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Application.Exit();
        }

        private void tileDayToDo_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frmControlScreen frmCS = new frmControlScreen();
            frmCS.ShowDialog();
        }

       
    }
}
