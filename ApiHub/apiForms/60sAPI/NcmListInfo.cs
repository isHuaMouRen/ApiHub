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

namespace ApiHub.apiForms._60sAPI
{
    public partial class NcmListInfo : Form
    {
        public class JsonConfig
        {
            public class Root
            {
                public int code { get; set; }
                public string message { get; set; }
                public JsonConfig.Data[] data { get; set; }
            }

            public class Data
            {
                public long id { get; set; }
                public string rank_name { get; set; }
                public string title { get; set; }
                public JsonConfig.Artist[] artist { get; set; }
                public JsonConfig.Album album { get; set; }
                public string duration_desc { get; set; }
                public JsonConfig.Mb mb { get; set; }
                public string link { get; set; }

            }

            public class Artist
            {
                public long id { get; set; }
                public string name { get; set; }
                public string cover { get; set; }
                public string link { get; set; }
            }

            public class Album
            {
                public long id { get; set; }
                public string name { get; set; }
                public string cover { get; set; }
                public string published { get; set; }
            }

            public class Mb
            {
                public JsonConfig.FileInfo sq { get; set; }
                public JsonConfig.FileInfo hq { get; set; }
                public JsonConfig.FileInfo mq { get; set; }
                public JsonConfig.FileInfo lq { get; set; }
            }

            public class FileInfo
            {
                public string size_desc { get; set; }
                public long bitrate { get; set; }
                public string extension { get; set; }
            }
        }

        public static JsonConfig.Root apiData;

        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;
                button_Search.Enabled = false;
                textBox_ID.Enabled = false;
                linkLabel_GetID.Enabled = false;

                using (HttpClient client = new HttpClient())
                {
                    File.WriteAllText(Main_Window.TempPath, await client.GetStringAsync($"{Main_Window.APIURL._60sAPI.ncmList}/{textBox_ID.Text}"));
                    apiData = NormalFunc.ReadJson<JsonConfig.Root>(Main_Window.TempPath);
                }

                if (apiData.code == 200)
                {
                    if (apiData.data.Length < 1) 
                    {
                        MessageBox.Show($"未获取到任何数据，请稍等一段时间后重试，或请检查榜单ID是否正确\n\n注意: 榜单ID是从 \"[实时] 网易云榜单列表\" 中获取的，并非歌曲ID！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        label_RankName.Text = $"榜单: {apiData.data[0].rank_name}";

                        listView_main.Items.Clear();
                        for (int i = 0; i < apiData.data.Length; i++)
                        {
                            ListViewItem item = new ListViewItem($"{apiData.data[i].title}");
                            item.SubItems.Add($"{apiData.data[i].artist[0].name}");
                            item.SubItems.Add($"{apiData.data[i].album.name}");
                            item.SubItems.Add($"{apiData.data[i].album.published}");
                            listView_main.Items.Add(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"发生了API内部错误\n\n错误代码: {apiData.code}\n错误信息: {apiData.message}", "API内部错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                button_Refresh.Enabled = true;
                button_Search.Enabled = true;
                textBox_ID.Enabled = true;
                linkLabel_GetID.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                button_Search.Enabled = true;
                textBox_ID.Enabled = true;
                linkLabel_GetID.Enabled = true;
                MessageBox.Show($"在获取API数据时发生错误!\n\n错误:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }










        public static int selectIndex;

        public Size listMinSize;
        public int textBoxMinWidth;

        public NcmListInfo()
        {
            InitializeComponent();

            listMinSize = this.Size - listView_main.Size;
            textBoxMinWidth = this.Width - textBox_ID.Width;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void NcmListInfo_Resize(object sender, EventArgs e)
        {
            listView_main.Size = this.Size - listMinSize;
            textBox_ID.Width = this.Width - textBoxMinWidth;
        }

        private void listView_main_ItemActivate(object sender, EventArgs e)
        {
            using (NcmListInfo_Song window = new NcmListInfo_Song())
            {
                selectIndex = listView_main.SelectedIndices[0];
                window.ShowDialog();
            }
        }

        private void linkLabel_GetID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (NcmList window = new NcmList())
            {
                window.ShowDialog();
            }
        }
    }
}
