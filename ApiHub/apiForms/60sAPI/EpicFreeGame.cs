using Newtonsoft.Json;
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

namespace ApiHub.apiForms._60sAPI
{
    public partial class EpicFreeGame : Form
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
                public string original_price_desc { get; set; }
                public string description { get; set; }
                public bool is_free_now { get; set; }
                public string free_start { get; set; }
                public string free_end { get; set; }
                public string link { get; set; }
            }
        }

        public JsonConfig.Root apiData;

        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;
                listView1.Enabled = false;

                using (HttpClient client = new HttpClient())
                {
                    apiData = JsonConvert.DeserializeObject<JsonConfig.Root>(await client.GetStringAsync(Main_Window.APIURL._60sAPI.epicFreeGame));
                }

                if (apiData.code == 200)
                {
                    listView1.Items.Clear();
                    for (int i = 0; i < apiData.data.Length; i++)
                    {
                        ListViewItem item = new ListViewItem($"{apiData.data[i].title}");
                        item.SubItems.Add($"{apiData.data[i].description}");
                        item.SubItems.Add($"{apiData.data[i].original_price_desc}");
                        if (apiData.data[i].is_free_now)
                        {
                            item.SubItems.Add($"是");
                        }
                        else
                        {
                            item.SubItems.Add($"否");
                        }
                        item.SubItems.Add($"{apiData.data[i].free_start}");
                        item.SubItems.Add($"{apiData.data[i].free_end}");

                        listView1.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show($"发生了API内部错误\n\n错误代码: {apiData.code}\n错误信息: {apiData.message}", "API内部错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                button_Refresh.Enabled = true;
                listView1.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                listView1.Enabled = true;
                MessageBox.Show($"在获取API数据时发生错误\n\n错误:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public Size minSize;

        public EpicFreeGame()
        {
            InitializeComponent();

            minSize = this.Size - listView1.Size;
        }

        private void EpicFreeGame_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void EpicFreeGame_Resize(object sender, EventArgs e)
        {
            listView1.Size = this.Size - minSize;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            int i = listView1.SelectedIndices[0];
            if (MessageBox.Show($"{apiData.data[i].title}\n\n{apiData.data[i].description}\n\n原价: {apiData.data[i].original_price_desc}\n\n\n开始免费: {apiData.data[i].free_start}\n结束免费: {apiData.data[i].free_end}\n\n链接: {apiData.data[i].link}\n\n点击\"是\"跳转链接\n点击\"否\"留在程序", "详细信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Process.Start($"{apiData.data[i].link}");
            }
        }
    }
}
