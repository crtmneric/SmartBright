using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Rnapos
{
    public partial class frmControlScreen : Form
    {
        public frmControlScreen()
        {
            InitializeComponent();
        }
        String[] kanallar = new String[10];
        String selectedChannels;
        int counter = 0;
        private void frmControlScreen_Load(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(241, 132, 16);
            btnSettingOkay.BackColor = color;         
            this.BackColor = color;
           
           
                    
        }
        private void getWeatherData()
        {
            String jsonWeather = getRequestFromUrl("http://api.openweathermap.org/data/2.5/forecast?id=323786&APPID=74de847e979086bfc01f4a38d5d23392");
            dynamic results = JsonConvert.DeserializeObject<dynamic>(jsonWeather);

            var temp = results.list[0].main.temp_max;
            var icon = results.list[0].weather[0].icon;           
            var tempMin = results.list[0].main.temp_min;
            string tempKelvin = Convert.ToString(temp).Substring(0, 3);
            string tempKelvinMin = Convert.ToString(tempMin).Substring(0, 3);
            int CelciusMin = Convert.ToInt32(tempKelvinMin) - 273;
            int Celcius = Convert.ToInt32(tempKelvin) - 273;
            txtTemp.Text = "-Maximum Sıcaklıklar-" + Environment.NewLine + Celcius + " C";
            txtMinTemp.Text = "-Minimum Sıcaklıklar-" + Environment.NewLine + CelciusMin + " C";
            webBrowser1.Navigate("http://openweathermap.org/img/w/" + Convert.ToString(icon)+".png");

             temp = results.list[1].main.temp_max;
             icon = results.list[1].weather[0].icon;       
             tempMin = results.list[1].main.temp_min;
             tempKelvin = Convert.ToString(temp).Substring(0, 3);
             tempKelvinMin = Convert.ToString(tempMin).Substring(0, 3);
             CelciusMin = Convert.ToInt32(tempKelvinMin) - 273;
             Celcius = Convert.ToInt32(tempKelvin) - 273;
            txtTemp.Text +=Environment.NewLine + Celcius + " C";
            txtMinTemp.Text += Environment.NewLine + CelciusMin + " C";
            webBrowser2.Navigate("http://openweathermap.org/img/w/" + Convert.ToString(icon) + ".png");

            temp = results.list[2].main.temp_max;
            icon = results.list[2].weather[0].icon;
            tempMin = results.list[2].main.temp_min;
            tempKelvin = Convert.ToString(temp).Substring(0, 3);
            tempKelvinMin = Convert.ToString(tempMin).Substring(0, 3);
            CelciusMin = Convert.ToInt32(tempKelvinMin) - 273;
            Celcius = Convert.ToInt32(tempKelvin) - 273;
            txtTemp.Text += Environment.NewLine + Celcius + " C";
            txtMinTemp.Text += Environment.NewLine + CelciusMin + " C";
            webBrowser3.Navigate("http://openweathermap.org/img/w/" + Convert.ToString(icon) + ".png");

            temp = results.list[3].main.temp_max;
            icon = results.list[3].weather[0].icon;
            tempMin = results.list[3].main.temp_min;
            tempKelvin = Convert.ToString(temp).Substring(0, 3);
            tempKelvinMin = Convert.ToString(tempMin).Substring(0, 3);
            CelciusMin = Convert.ToInt32(tempKelvinMin) - 273;
            Celcius = Convert.ToInt32(tempKelvin) - 273;
            txtTemp.Text += Environment.NewLine + Celcius + " C";
            txtMinTemp.Text += Environment.NewLine + CelciusMin + " C";
            webBrowser4.Navigate("http://openweathermap.org/img/w/" + Convert.ToString(icon) + ".png");

            temp = results.list[4].main.temp_max;
            icon = results.list[4].weather[0].icon;
            tempMin = results.list[4].main.temp_min;
            tempKelvin = Convert.ToString(temp).Substring(0, 3);
            tempKelvinMin = Convert.ToString(tempMin).Substring(0, 3);
            CelciusMin = Convert.ToInt32(tempKelvinMin) - 273;
            Celcius = Convert.ToInt32(tempKelvin) - 273;
            txtTemp.Text += Environment.NewLine + Celcius + " C";
            txtMinTemp.Text += Environment.NewLine + CelciusMin + " C";
            webBrowser5.Navigate("http://openweathermap.org/img/w/" + Convert.ToString(icon) + ".png");

            temp = results.list[5].main.temp_max;
            icon = results.list[5].weather[0].icon;
            tempMin = results.list[5].main.temp_min;
            tempKelvin = Convert.ToString(temp).Substring(0, 3);
            tempKelvinMin = Convert.ToString(tempMin).Substring(0, 3);
            CelciusMin = Convert.ToInt32(tempKelvinMin) - 273;
            Celcius = Convert.ToInt32(tempKelvin) - 273;
            txtTemp.Text += Environment.NewLine + Celcius + " C";
            txtMinTemp.Text += Environment.NewLine + CelciusMin + " C";
            webBrowser6.Navigate("http://openweathermap.org/img/w/" + Convert.ToString(icon) + ".png");

            temp = results.list[6].main.temp_max;
            icon = results.list[6].weather[0].icon;
            tempMin = results.list[6].main.temp_min;
            tempKelvin = Convert.ToString(temp).Substring(0, 3);
            tempKelvinMin = Convert.ToString(tempMin).Substring(0, 3);
            CelciusMin = Convert.ToInt32(tempKelvinMin) - 273;
            Celcius = Convert.ToInt32(tempKelvin) - 273;
            txtTemp.Text += Environment.NewLine + Celcius + " C";
            txtMinTemp.Text += Environment.NewLine + CelciusMin + " C";
            webBrowser7.Navigate("http://openweathermap.org/img/w/" + Convert.ToString(icon) + ".png");

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPort_Click(object sender, EventArgs e)
        {
            kanallar = SerialPort.GetPortNames();
            List<string> datasource = kanallar.ToList();
            cmbPort.DataSource = datasource;
            prgBarVerim.Properties.StartColor = Color.Red;
            prgBarVerim.Properties.EndColor = Color.Green;
        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedChannels = Convert.ToString(cmbPort.SelectedItem);
            serialPort1.PortName = selectedChannels;
        }

        private void btnSettingOkay_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            tmrPortRead.Enabled = true;
            tmrSerialWrite.Enabled = true;
            getWeatherData();
           
        }

        private void tmrPortRead_Tick(object sender, EventArgs e)
        {
            char editVerim = '0';
            String verimStr = serialPort1.ReadExisting();
            if(!String.IsNullOrEmpty(verimStr))
            {
                editVerim = verimStr[0]; 
            }
                  
            if(editVerim=='0')
            {
                prgBarVerim.Position= 0;
                
                 lblVerim.Text = "Solar Panel Verimliliği Şuan:%" + editVerim+"0" ;
            }
            if (editVerim == '1')
            {
                prgBarVerim.Position = 1;
               
                 lblVerim.Text = "Solar Panel Verimliliği Şuan:%" + editVerim+"0" ;
            }
            if (editVerim == '2')
            {
                prgBarVerim.Position = 2;
                
                 lblVerim.Text = "Solar Panel Verimliliği Şuan:%" + editVerim+"0" ;
            }
            if (editVerim == '3')
            {
                prgBarVerim.Position = 3;
                
                 lblVerim.Text = "Solar Panel Verimliliği Şuan:%" + editVerim+"0" ;
            }
            if (editVerim == '4')
            {
                prgBarVerim.Position = 4;
               
                lblVerim.Text = "Solar Panel Verimliliği Şuan:%" + editVerim+"0" ;
            }
            if (editVerim == '5')
            {
                prgBarVerim.Position = 5;

                lblVerim.Text = "Solar Panel Verimliliği Şuan:%" + editVerim + "0";
            }
            if (editVerim == '6')
            {
                prgBarVerim.Position = 6;
              
                 lblVerim.Text = "Solar Panel Verimliliği Şuan:%" + editVerim+"0" ;
            }
            if (editVerim == '7')
            {
                prgBarVerim.Position = 7;
               
                 lblVerim.Text = "Solar Panel Verimliliği Şuan:%" + editVerim+"0" ;
            }
            if (editVerim == '8')
            {
                prgBarVerim.Position = 8;
                
                 lblVerim.Text = "Solar Panel Verimliliği Şuan:%" + editVerim+"0" ;
            }
            if (editVerim == '9')
            {
                prgBarVerim.Position = 9;
              
                 lblVerim.Text = "Solar Panel Verimliliği Şuan:%" + editVerim+"0" ;
            }
            Random rnd = new Random();
            int uretim = rnd.Next(55, 60);
            int tuketim = rnd.Next(35, 45);
            int verimcik = (int)Char.GetNumericValue(editVerim);
            verimPostMethod(editVerim + "0");
           //tuketimUretimPostMethod(Convert.ToString((uretim * Convert.ToInt32(editVerim)) / 10),tuketim.ToString());
            prgBarVerim.Update();
          
        }

        private void frmControlScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPortRead.Enabled = false;
            tmrSerialWrite.Enabled = false;
            serialPort1.Close();
        }
        private string getRequestFromUrl(String url)
        {
           
            try
            {
                string rt;
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                rt = reader.ReadToEnd();
                reader.Close();
                response.Close();
                return rt;
            }

            catch (Exception ex)
            {
                return "";
            }
        }
        private void verimPostMethod(string verim)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://kanlazimapp.com/smartbright/test.php");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"verim\":\""+verim+"\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                //MessageBox.Show(result.ToString());
            }
        }

        private void tmrSerialWrite_Tick(object sender, EventArgs e)
        {
            String eftalJson= getRequestFromUrl("http://kanlazimapp.com/smartbright/php/current_plan.php");
            dynamic results = JsonConvert.DeserializeObject<dynamic>(eftalJson);
            var currentPlan = results.current_plan;
            var planName = results.plan_name;
            var clicked = results.clicked;
          

            if (Convert.ToString(clicked) == "1"&& Convert.ToString(currentPlan)=="1")
            {
                lblMod.Text = "Aktif Mod:" + Convert.ToString(planName);

            }
            if (Convert.ToString(clicked) == "1" && Convert.ToString(currentPlan) == "2")
            {

                lblMod.Text = "Aktif Mod:" + Convert.ToString(planName);
            }
            if (Convert.ToString(clicked) == "1" && Convert.ToString(currentPlan) == "3")
            {

                lblMod.Text = "Aktif Mod:" + Convert.ToString(planName);
            }

            
            if(Convert.ToString(currentPlan)=="1")
            {
                byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes("t");
                serialPort1.Write(MyMessage, 0, MyMessage.Length);
               
            }
            if (Convert.ToString(currentPlan) == "2")
            {
                byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes("k");
                serialPort1.Write(MyMessage, 0, MyMessage.Length);
            }
            if (Convert.ToString(currentPlan) == "3")
            {
                byte[] MyMessage = System.Text.Encoding.UTF8.GetBytes("y");
                serialPort1.Write(MyMessage, 0, MyMessage.Length);
            }

           
           
           
        }
       
    }
}
