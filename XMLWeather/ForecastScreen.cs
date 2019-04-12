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

            date1.Text = DateTime.Now.ToString("dddd");
            min1.Text = "Min: " + Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + "°C";
            max1.Text = "Max: " + Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + "°C";
            conditions1.Image = GetSymbol(0);

            date2.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            min2.Text = "Min: " + Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + "°C";
            max2.Text = "Max: " + Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + "°C";
            conditions2.Image = GetSymbol(1);

            date3.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            min3.Text = "Min: " + Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + "°C";
            max3.Text = "Max: " + Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + "°C";
            conditions3.Image = GetSymbol(2);
        }

        public Image GetSymbol(int d)
        {
            double code = Convert.ToDouble(Form1.days[d].conditionNumber);

            //Thunder
            if (code > 199 && code < 300)
            {
                return XMLWeather.Properties.Resources.rain;
            }
            //Rain
            if (code > 299 && code < 400)
            {
                return XMLWeather.Properties.Resources.rain;
            }
            //Light Rain
            else if (code > 499 && code < 600)
            {
                return XMLWeather.Properties.Resources.light_rain;
            }
            //Snow
            else if (code > 599 && code < 700)
            {
                return XMLWeather.Properties.Resources.snow;
            }
            //Clear or Cloudy
            else
            {
                return XMLWeather.Properties.Resources.clear;
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
