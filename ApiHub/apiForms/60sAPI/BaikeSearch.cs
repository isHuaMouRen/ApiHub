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
    public partial class BaikeSearch : Form
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
                public string title { get; set; }
                public string description { get; set; }
                public string @abstract { get; set; }
                public string cover { get; set; }
                public string link { get; set; }
            }
        }

        public JsonConfig.Root apiData;

        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;
                button_Search.Enabled = false;
                textBox_Search.Enabled = false;

                using (HttpClient client = new HttpClient())
                {
                    apiData = JsonConvert.DeserializeObject<JsonConfig.Root>(await client.GetStringAsync($"{Main_Window.APIURL._60sAPI.baikeSearch}?word={textBox_Search.Text}"));

                    Stream stream = await client.GetStreamAsync($"{apiData.data.cover}");
                    pictureBox1.Image = Image.FromStream(stream);
                }

                if (apiData.code == 200)
                {
                    label_Titlee.Text = $"{apiData.data.title}";
                    label_Description.Text = $"{apiData.data.description}";
                    label_Abstract.Text = $"{apiData.data.@abstract}";
                }
                else
                {
                    MessageBox.Show($"发生了API内部错误\n\n错误代码: {apiData.code}\n错误信息: {apiData.message}", "API内部错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                button_Refresh.Enabled = true;
                button_Search.Enabled = true;
                textBox_Search.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                button_Search.Enabled = true;
                textBox_Search.Enabled = true;
                MessageBox.Show($"在获取API数据时发生错误\n\n错误:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        public BaikeSearch()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }
    }
}
