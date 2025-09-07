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
    public partial class Fanyi : Form
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
                public JsonConfig.LanguageInfo source { get; set; }
                public JsonConfig.LanguageInfo target { get; set; }
            }

            public class LanguageInfo
            {
                public string text { get; set; }
                public string type_desc { get; set; }
                public string pronounce { get; set; }
            }
        }

        public JsonConfig.Root apiData;

        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;
                button_Translate.Enabled = false;
                textBox_From.Enabled = false;
                textBox_To.Enabled = false;
                textBox_Source.Enabled = false;
                textBox_Target.Enabled = false;

                using (HttpClient client = new HttpClient())
                {
                    File.WriteAllText(Main_Window.TempPath, await client.GetStringAsync($"{Main_Window.APIURL._60sAPI.fanyi}?text={textBox_Source.Text}&from={textBox_From.Text}&to={textBox_To.Text}"));
                    apiData = Funcitons.NormalFunc.ReadJson<JsonConfig.Root>(Main_Window.TempPath);
                }

                if (apiData.code == 200)
                {
                    textBox_Target.Text = apiData.data.target.text;
                }
                else
                {
                    MessageBox.Show($"Internal Error of the API\n||==========||\n\nError code: {apiData.code}\nError message: {apiData.message}", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    button_Refresh.Enabled = true;
                button_Translate.Enabled = true;
                textBox_From.Enabled = true;
                textBox_To.Enabled = true;
                textBox_Source.Enabled = true;
                textBox_Target.Enabled = true;

            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                button_Translate.Enabled = true;
                textBox_From.Enabled = true;
                textBox_To.Enabled = true;
                textBox_Source.Enabled = true;
                textBox_Target.Enabled = true;
                MessageBox.Show($"Error Report\n||==========||\n\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }














        public Fanyi()
        {
            InitializeComponent();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Translate_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void linkLabel_GetLanguageCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FanyiList window = new FanyiList())
            {
                window.ShowDialog();
            }
        }
    }
}
