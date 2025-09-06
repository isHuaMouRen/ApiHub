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
using Funcitons;

namespace ApiHub.apiForms
{
    public partial class BaiduTvHot : Form
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
                public string title { get; set; }
                public string desc { get; set; }
                public string score_desc { get; set; }
                public string url { get; set; }
            }
        }

        public static JsonConfig.Root apiData;

        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;
                listView_main.Enabled = false;

                using (HttpClient client = new HttpClient())
                {
                    File.WriteAllText(Main_Window.TempPath, await client.GetStringAsync(Main_Window.APIURL.baiduTvHot));
                    apiData = Funcitons.NormalFunc.ReadJson<JsonConfig.Root>(Main_Window.TempPath);
                }

                if (apiData.code == 200)
                {
                    listView_main.Items.Clear();
                    for (int i = 0; i < apiData.data.Length; i++)
                    {
                        ListViewItem item = new ListViewItem($"{apiData.data[i].title}");
                        item.SubItems.Add($"{apiData.data[i].desc}");
                        item.SubItems.Add($"{apiData.data[i].score_desc}");

                        listView_main.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show($"发生了API内部错误\n\n错误代码: {apiData.code}\n错误信息: {apiData.message}", "API内部错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                button_Refresh.Enabled = true;
                listView_main.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                listView_main.Enabled = true;
                MessageBox.Show($"在获取API数据时发生错误\n\n错误:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }














        public static Size minSize;

        public BaiduTvHot()
        {
            InitializeComponent();

            minSize = this.Size - listView_main.Size;
        }

        private void BaiduTvHot_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void BaiduTvHot_Resize(object sender, EventArgs e)
        {
            listView_main.Size = this.Size - minSize;
        }

        private void listView_main_ItemActivate(object sender, EventArgs e)
        {
            if (listView_main.SelectedItems.Count > 0)
            {
                int index = listView_main.SelectedIndices[0];

                if (MessageBox.Show($"{apiData.data[index].title}\n\n{apiData.data[index].desc}\n\n热度: {apiData.data[index].score_desc}\n\n\n链接: {apiData.data[index].url}", $"详细信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    Process.Start($"{apiData.data[index].url}");
                }
            }
        }
    }
}
