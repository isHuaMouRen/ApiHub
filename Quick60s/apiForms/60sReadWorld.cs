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
using Funcitons;
using static Funcitons.NormalFunc;

namespace ApiHub.apiForms
{
    public partial class _60sReadWorld : Form
    {
        public class API
        {
            public class Root
            {
                public int code { get; set; }
                public string message { get; set; }
                public API.Data data { get; set; }
            }

            public class Data
            {
                public string date { get; set; }
                public string[] news { get; set; }
                public string tip { get; set; }
                public string link { get; set; }
                public string created { get; set; }
                public string updated { get; set; }
                public string api_updated { get; set; }
            }
        }

        public API.Root apiData;






        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;

                using (HttpClient http = new HttpClient())
                {
                    File.WriteAllText(Main_Window.TempPath, await http.GetStringAsync(Main_Window.APIURL._60sReadworld));
                    apiData = ReadJson<API.Root>(Main_Window.TempPath);
                }

                if (apiData.code == 200)
                {

                    label_Date.Text = $"日期: {apiData.data.date}";


                    textBox_Content.Text = "";
                    for (int i = 0; i < apiData.data.news.Length; i++)
                    {
                        textBox_Content.Text = $"{textBox_Content.Text}{i + 1}.  {apiData.data.news[i]}\r\n\r\n";
                    }


                    label_tip.Text = $"——{{ {apiData.data.tip} }}——";
                    label_update.Text = $"更新时间: {apiData.data.updated}   API更新时间: {apiData.data.api_updated}";

                }
                else
                {
                    MessageBox.Show($"API内部错误\n\n错误代码: {apiData.code}\n错误信息: {apiData.message}", "API内部错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                button_Refresh.Enabled = true;

            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                MessageBox.Show($"在获取API数据时发生错误!\n\n错误原因:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //========================================
        public _60sReadWorld()
        {
            InitializeComponent();
        }

        private void _60sReadWorld_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void _60sReadWorld_Resize(object sender, EventArgs e)
        {
            button_Refresh.Left = this.Width - 135;
            label_tip.Top = this.Height - 100;
            label_tip.Width = this.Width - 40;

            label_update.Top = this.Height - 70;
            label_update.Width = this.Width - 40;

            textBox_Content.Size = new Size(this.Width - 40, this.Height - 189);
        }
    }
}
