using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Funcitons.NormalFunc;

namespace ApiHub.apiForms
{
    public partial class bingWallpaper : Form
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
                public string title { get; set; }
                public string headline { get; set; }
                public string cover { get; set; }
                public string cover_4k { get; set; }
                public string copyright { get; set; }
                public string update_date { get; set; }
            }
        }

        public static API.Root APIData;        

        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;
                button_Download4K.Enabled = false;
                button_Download1080p.Enabled = false;

                using (HttpClient http = new HttpClient())
                {
                    File.WriteAllText(Main_Window.TempPath, await http.GetStringAsync(Main_Window.APIURL._60sAPI.bingWallpaper));
                    APIData = ReadJson<API.Root>(Main_Window.TempPath);

                    if (APIData.code == 200)
                    {
                        pictureBox_overview.Image = Image.FromStream(await http.GetStreamAsync(APIData.data.cover));

                        label_image_title.Text = $"{APIData.data.title}";
                        label_image_headline.Text = $"{APIData.data.headline}";
                        label_Copyright.Text = $"Copyright: {APIData.data.copyright}";
                    }
                    else
                    {
                        MessageBox.Show($"发生了API内部错误!\n\n错误代码: {APIData.code}\n错误信息: {APIData.message}", "API内部错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                button_Refresh.Enabled = true;
                button_Download4K.Enabled = true;
                button_Download1080p.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                button_Download4K.Enabled = true;
                button_Download1080p.Enabled = true;
                MessageBox.Show($"在获取API数据时发生错误!\n\n错误原因:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }










        public bingWallpaper()
        {
            InitializeComponent();
        }

        private void bingWallpaper_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Download1080p_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(APIData.data.cover) { UseShellExecute = true });
        }

        private void button_Download4K_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(APIData.data.cover_4k) { UseShellExecute = true });
        }
    }
}
