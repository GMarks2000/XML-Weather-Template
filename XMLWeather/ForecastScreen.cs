using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {
            titleLabel.Text = "This Week In " + Form1.days[0].location;

            //title location box
            titleLabel.Location = new Point(this.Width / 2 - titleLabel.Width / 2, titleLabel.Location.Y);

            returnLabel.Parent = returnCircle;
            returnLabel.Location = new Point(returnCircle.Width / 2 - returnLabel.Width / 2, returnCircle.Height / 2 - returnLabel.Height / 2);

            //sets day label text
            day1Label.Text = DateTime.Now.AddDays(1).ToString("ddd");
            day2Label.Text = DateTime.Now.AddDays(2).ToString("ddd");
            day3Label.Text = DateTime.Now.AddDays(3).ToString("ddd");
            day4Label.Text = DateTime.Now.AddDays(4).ToString("ddd");
            day5Label.Text = DateTime.Now.AddDays(5).ToString("ddd");

            //sets high and low temp labels
            high1Label.Text = Form1.days[1].tempHigh + " °C"; 
            high2Label.Text = Form1.days[2].tempHigh + " °C"; 
            high3Label.Text = Form1.days[3].tempHigh + " °C"; 
            high4Label.Text = Form1.days[4].tempHigh + " °C"; 
            high5Label.Text = Form1.days[5].tempHigh + " °C"; 

            low1Label.Text = Form1.days[1].tempLow + " °C"; 
            low2Label.Text = Form1.days[2].tempLow + " °C"; 
            low3Label.Text = Form1.days[3].tempLow + " °C"; 
            low4Label.Text = Form1.days[4].tempLow + " °C";
            low5Label.Text = Form1.days[5].tempLow + " °C";

            //determines weather image
            switch (Form1.days[1].condition)
            {
                case "overcast clouds":
                    iconBox1.BackgroundImage = Properties.Resources.Thunder2;
                    break;
                case "broken clouds":
                    iconBox1.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "scattered clouds":
                    iconBox1.BackgroundImage = Properties.Resources.Cloud3;
                    break;
                case "few clouds":
                    iconBox1.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "clear sky":
                    iconBox1.BackgroundImage = Properties.Resources.Sun2;
                    break;
                default:
                    iconBox1.BackgroundImage = Properties.Resources.Sun2;
                    break;
            }

            //determines weather image
            switch (Form1.days[2].condition)
            {
                case "overcast clouds":
                    iconBox2.BackgroundImage = Properties.Resources.Thunder2;
                    break;
                case "broken clouds":
                    iconBox2.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "scattered clouds":
                    iconBox2.BackgroundImage = Properties.Resources.Cloud3;
                    break;
                case "few clouds":
                    iconBox2.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "clear sky":
                    iconBox2.BackgroundImage = Properties.Resources.Sun2;
                    break;
                default:
                    iconBox2.BackgroundImage = Properties.Resources.Sun2;
                    break;
            }

            //determines weather image
            switch (Form1.days[3].condition)
            {
                case "overcast clouds":
                    iconBox3.BackgroundImage = Properties.Resources.Thunder2;
                    break;
                case "broken clouds":
                    iconBox3.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "scattered clouds":
                    iconBox3.BackgroundImage = Properties.Resources.Cloud3;
                    break;
                case "few clouds":
                    iconBox3.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "clear sky":
                    iconBox3.BackgroundImage = Properties.Resources.Sun2;
                    break;
                default:
                    iconBox3.BackgroundImage = Properties.Resources.Sun2;
                    break;
            }

            //determines weather image
            switch (Form1.days[4].condition)
            {
                case "overcast clouds":
                    iconBox4.BackgroundImage = Properties.Resources.Thunder2;
                    break;
                case "broken clouds":
                    iconBox4.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "scattered clouds":
                    iconBox4.BackgroundImage = Properties.Resources.Cloud3;
                    break;
                case "few clouds":
                    iconBox4.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "clear sky":
                    iconBox4.BackgroundImage = Properties.Resources.Sun2;
                    break;
                default:
                    iconBox4.BackgroundImage = Properties.Resources.Sun2;
                    break;
            }

            //determines weather image
            switch (Form1.days[5].condition)
            {
                case "overcast clouds":
                    iconBox5.BackgroundImage = Properties.Resources.Thunder2;
                    break;
                case "broken clouds":
                    iconBox5.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "scattered clouds":
                    iconBox5.BackgroundImage = Properties.Resources.Cloud3;
                    break;
                case "few clouds":
                    iconBox5.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "clear sky":
                    iconBox5.BackgroundImage = Properties.Resources.Sun2;
                    break;
                default:
                    iconBox5.BackgroundImage = Properties.Resources.Sun2;
                    break;
            }

            humidityLabel1.Text = Form1.days[1].humidity + " %";
            humidityLabel2.Text = Form1.days[2].humidity + " %";
            humidityLabel3.Text = Form1.days[3].humidity + " %";
            humidityLabel4.Text = Form1.days[4].humidity + " %";
            humidityLabel5.Text = Form1.days[5].humidity + " %";

        }

        private void returnCircle_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void iconBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
