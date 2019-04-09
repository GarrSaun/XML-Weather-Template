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
            dateLabel.Text = Form1.days[0].date;
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp + "’C";
            minOutput.Text = Form1.days[0].tempLow + "’C";
            maxOutput.Text = Form1.days[0].tempHigh + "’C";

            //Thunder
            if (Convert.ToInt16(Form1.days[0].conditionNumber) > 199 && Convert.ToInt16(Form1.days[0].conditionNumber) < 300)
            {
                conditionBox.Image = XMLWeather.Properties.Resources.rain;
            }
            //Rain
            if (Convert.ToInt16(Form1.days[0].conditionNumber) > 299 && Convert.ToInt16(Form1.days[0].conditionNumber) < 400)
            {
                conditionBox.Image = XMLWeather.Properties.Resources.rain;
            }
            //Light Rain
            else if (Convert.ToInt16(Form1.days[0].conditionNumber) > 499 && Convert.ToInt16(Form1.days[0].conditionNumber) < 600)
            {
                conditionBox.Image = XMLWeather.Properties.Resources.light_rain;
            }
            //Light Rain
            else if (Convert.ToInt16(Form1.days[0].conditionNumber) > 599 && Convert.ToInt16(Form1.days[0].conditionNumber) < 700)
            {
                conditionBox.Image = XMLWeather.Properties.Resources.snow;
            }
            //Clear or Cloudy
            else
            {
                conditionBox.Image = XMLWeather.Properties.Resources.clear;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
