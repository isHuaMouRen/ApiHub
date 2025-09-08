using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiHub.apiForms._60sAPI
{
    public partial class Weather : Form
    {
        public class JsonConfig
        {
            public class Root
            {
                public int code { get; set; }
                public string message { get; set; }
                public JsonConfig.Data data { get; set; }
            }

            public class Data
            {
                public JsonConfig.Location location { get; set; }
                public JsonConfig.Weather weather { get; set; }
                public JsonConfig.AirQuality air_quality { get; set; }
                public JsonConfig.Sunrise sunrise { get; set; }
                public JsonConfig.LifeIndices[] life_indices { get; set; }
            }

            public class Location
            {
                public string province { get; set; }
                public string city { get; set; }
            }

            public class Weather
            {
                public string condition { get; set; }
                public int temperature { get; set; }
                public int humidity { get; set; }
                public string wind_direction { get; set; }
                public string wind_power { get; set; }
                public string weather_icon { get; set; }
                public string updated { get; set; }
            }

            public class AirQuality
            {
                public string quality { get; set; }
            }

            public class Sunrise
            {
                public string sunrise_desc { get; set; }
                public string sunset_desc { get; set; }
            }

            public class LifeIndices
            {
                public string name { get; set; }
                public string level { get; set; }
                public string description { get; set; }
            }
        }

        public JsonConfig.Root apiData;

        public async void RefreshAPI()
        {
            try
            {
                button_Refreh.Enabled = false;
                button_Search.Enabled = false;
                textBox_Search.Enabled = false;

                using (HttpClient client = new HttpClient())
                {
                    apiData = JsonConvert.DeserializeObject<JsonConfig.Root>(await client.GetStringAsync($"{Main_Window.APIURL._60sAPI.weather}?query={textBox_Search.Text}"));

                    Stream stream = await client.GetStreamAsync(apiData.data.weather.weather_icon);
                    pictureBox_WeatherIcon.Image = Image.FromStream(stream);
                }

                if (apiData.code == 200)
                {
                    label_Title.Text = $"{apiData.data.location.province} - {apiData.data.location.city}";
                    label_UpdateDate.Text = $"更新时间: {apiData.data.weather.updated}";
                    label_Weather.Text = $"天气: {apiData.data.weather.condition}  温度: {apiData.data.weather.temperature}  湿度: {apiData.data.weather.humidity}  风向: {apiData.data.weather.wind_direction}  风力: {apiData.data.weather.wind_power}  空气质量: {apiData.data.air_quality.quality}  日出: {apiData.data.sunrise.sunrise_desc}  日落: {apiData.data.sunrise.sunset_desc}";

                    textBox_tips.Text = "";
                    for (int i = 0; i < apiData.data.life_indices.Length; i++)
                    {
                        textBox_tips.Text = $"{textBox_tips.Text}{apiData.data.life_indices[i].name}: {apiData.data.life_indices[i].level}   {apiData.data.life_indices[i].description}\r\n";
                    }

                }
                else
                {
                    MessageBox.Show($"-----Internal error of API-----\n\nError code: {apiData.code}\nError message: {apiData.message}", "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    button_Refreh.Enabled = true;
                button_Search.Enabled = true;
                textBox_Search.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Refreh.Enabled = true;
                button_Search.Enabled = true;
                textBox_Search.Enabled = true;
                MessageBox.Show($"-----Error report-----\n\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }












        public Weather()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Refreh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }
    }
}
