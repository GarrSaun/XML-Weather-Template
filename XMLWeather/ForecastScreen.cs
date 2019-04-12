//Name: Weather App
//Author: Garrett Saunders
//Date: 
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
            double code1 = Convert.ToDouble(Form1.days[0].conditionNumber);
            double code2 = Convert.ToDouble(Form1.days[1].conditionNumber);
            double code3 = Convert.ToDouble(Form1.days[2].conditionNumber);

            date1.Text = Form1.days[0].date;
            min1.Text = "Min: " + Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + "°C";
            max1.Text = "Max: " + Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + "°C";
            #region Image
            //Thunder
            if (code1 > 199 && code1 < 300)
            {
                conditions1.Image = XMLWeather.Properties.Resources.rain;
            }
            //Rain
            if (code1 > 299 && code1 < 400)
            {
                conditions1.Image = XMLWeather.Properties.Resources.rain;
            }
            //Light Rain
            else if (code1 > 499 && code1 < 600)
            {
                conditions1.Image = XMLWeather.Properties.Resources.light_rain;
            }
            //Light Rain
            else if (code1 > 599 && code1 < 700)
            {
                conditions1.Image = XMLWeather.Properties.Resources.snow;
            }
            //Clear or Cloudy
            else
            {
                conditions1.Image = XMLWeather.Properties.Resources.clear;
            }
            #endregion

            date2.Text = Form1.days[1].date;
            min2.Text = "Min: " + Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + "°C";
            max2.Text = "Max: " + Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + "°C";
            #region Second Image
            //Thunder
            if (code2 > 199 && code2 < 300)
            {
                conditions2.Image = XMLWeather.Properties.Resources.rain;
            }
            //Rain
            if (code2 > 299 && code2 < 400)
            {
                conditions2.Image = XMLWeather.Properties.Resources.rain;
            }
            //Light Rain
            else if (code2 > 499 && code2 < 600)
            {
                conditions2.Image = XMLWeather.Properties.Resources.light_rain;
            }
            //Light Rain
            else if (code2 > 599 && code2 < 700)
            {
                conditions2.Image = XMLWeather.Properties.Resources.snow;
            }
            //Clear or Cloudy
            else
            {
                conditions2.Image = XMLWeather.Properties.Resources.clear;
            }
            #endregion

            date3.Text = Form1.days[2].date;
            min3.Text = "Min: " + Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + "°C";
            max3.Text = "Max: " + Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + "°C";
            #region Third Image
            //Thunder
            if (code3 > 199 && code3 < 300)
            {
                conditions3.Image = XMLWeather.Properties.Resources.rain;
            }
            //Rain
            if (code3 > 299 && code3 < 400)
            {
                conditions3.Image = XMLWeather.Properties.Resources.rain;
            }
            //Light Rain
            else if (code3 > 499 && code3 < 600)
            {
                conditions3.Image = XMLWeather.Properties.Resources.light_rain;
            }
            //Light Rain
            else if (code3 > 599 && code3 < 700)
            {
                conditions3.Image = XMLWeather.Properties.Resources.snow;
            }
            //Clear or Cloudy
            else
            {
                conditions3.Image = XMLWeather.Properties.Resources.clear;
            }
            #endregion
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
