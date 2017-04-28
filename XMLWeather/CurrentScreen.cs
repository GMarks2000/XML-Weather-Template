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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();

            
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {   
            //fetches appropriate label data
            titleLabel.Text = "Today in " + Form1.days[0].location;
            humidityLabel.Text = "Humidity: " + Form1.days[0].humidity + "%";
            windLabel.Text = "Wind Speed: " + Form1.days[0].windSpeed + " km/h";
            dateLabel.Text =  "Date: " + DateTime.Now.ToString("yy") + "  " + DateTime.Now.ToString("y");

            //title location box
            titleLabel.Location = new Point(this.Width / 2 - titleLabel.Width / 2, titleLabel.Location.Y);

            //parent changes to correct design
            tempLabel.Parent = tempCircle;

            tempLabel.Text = Form1.days[0].currentTemp + " °C";
            tempLabel.Location = new Point (tempCircle.Width / 2 - tempLabel.Width / 2, tempCircle.Height / 2 - tempLabel.Height / 2);

            forecastLabel.Parent = forecastCircle;
            forecastLabel.Location = new Point(forecastCircle.Width / 2 - forecastLabel.Width / 2, forecastCircle.Height / 2 - forecastLabel.Height / 2);
           
            //determines weather image
            switch (Form1.days[0].condition)
            {
                case "overcast clouds":
                    iconBox.BackgroundImage = Properties.Resources.Thunder2;
                    break;                   
                case "broken clouds":
                    iconBox.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "scattered clouds":
                    iconBox.BackgroundImage = Properties.Resources.Cloud3;
                    break;
                case "few clouds":
                    iconBox.BackgroundImage = Properties.Resources.SunCloud2;
                    break;
                case "clear sky":
                    iconBox.BackgroundImage = Properties.Resources.Sun2;
                    break;
                default:
                    iconBox.BackgroundImage = Properties.Resources.Sun2;
                    break;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void forecastCircle_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void forecastLabel_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
