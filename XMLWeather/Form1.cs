//Name: Weather App
//Author: Garrett Saunders
//Date: 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
            while (reader.Read())
            {
                Day d = new Day();

                //Conditions
                reader.ReadToFollowing("symbol");
                d.conditionNumber = reader.GetAttribute("number");
                
                //Current, min and max temperatures
                reader.ReadToFollowing("temperature");
                d.tempHigh = reader.GetAttribute("max");
                d.tempLow = reader.GetAttribute("min");

                if (d.date != null)
                {
                    days.Add(d);
                }
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //City
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");
            //Current, min and max temperatures
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
            days[0].tempLow = reader.GetAttribute("min");
            days[0].tempHigh = reader.GetAttribute("max");
            //Conditions
            reader.ReadToFollowing("weather");
            days[0].conditionNumber = reader.GetAttribute("number");
        }


    }
}
