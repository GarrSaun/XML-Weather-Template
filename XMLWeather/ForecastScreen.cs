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
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = "Min: " + Form1.days[1].tempLow + "'C";
            max1.Text = "Max: " + Form1.days[1].tempHigh + "'C";

            date2.Text = Form1.days[2].date;
            min2.Text = "Min: " + Form1.days[2].tempLow + "'C";
            max2.Text = "Max: " + Form1.days[2].tempHigh + "'C";

            date3.Text = Form1.days[3].date;
            min3.Text = "Min: " + Form1.days[3].tempLow + "'C";
            max3.Text = "Max: " + Form1.days[3].tempHigh + "'C";


            //Thunder
            if (Convert.ToInt16(Form1.days[0].conditionNumber) > 199 && Convert.ToInt16(Form1.days[0].conditionNumber) < 300)
            {
                conditions1.Image = XMLWeather.Properties.Resources.rain;
            }
            //Rain
            if (Convert.ToInt16(Form1.days[0].conditionNumber) > 299 && Convert.ToInt16(Form1.days[0].conditionNumber) < 400)
            {
                conditions1.Image = XMLWeather.Properties.Resources.rain;
            }
            //Light Rain
            else if (Convert.ToInt16(Form1.days[0].conditionNumber) > 499 && Convert.ToInt16(Form1.days[0].conditionNumber) < 600)
            {
                conditions1.Image = XMLWeather.Properties.Resources.light_rain;
            }
            //Light Rain
            else if (Convert.ToInt16(Form1.days[0].conditionNumber) > 599 && Convert.ToInt16(Form1.days[0].conditionNumber) < 700)
            {
                conditions1.Image = XMLWeather.Properties.Resources.snow;
            }
            //Clear or Cloudy
            else
            {
                conditions1.Image = XMLWeather.Properties.Resources.clear;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
