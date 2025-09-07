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
    public partial class BaiduHot : Form
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
                public string score_desc { get; set; }
                public string type_desc { get; set; }
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
                    File.WriteAllText(Main_Window.TempPath, await client.GetStringAsync(Main_Window.APIURL._60sAPI.baiduHot));
                    apiData = ReadJson<JsonConfig.Root>(Main_Window.TempPath);
                }

                if (apiData.code == 200)
                {
                    listView_main.Items.Clear();
                    for (int i = 0; i < apiData.data.Length; i++)
                    {
                        ListViewItem item = new ListViewItem($"{apiData.data[i].title}");
                        item.SubItems.Add($"{apiData.data[i].score_desc}");
                        item.SubItems.Add($"{apiData.data[i].type_desc}");

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
                MessageBox.Show($"在获取API数据时发生错误!\n\n错误原因:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


























        public static Size minSize;

        public BaiduHot()
        {
            InitializeComponent();

            minSize = this.Size - listView_main.Size;
        }

        private void BaiduHot_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void BaiduHot_Resize(object sender, EventArgs e)
        {
            listView_main.Size = this.Size - minSize;
        }

        private void listView_main_ItemActivate(object sender, EventArgs e)
        {
            if (listView_main.SelectedItems.Count > 0)
            {
                int index = listView_main.SelectedIndices[0];

                if (MessageBox.Show($"{apiData.data[index].title}\n\n热度: {apiData.data[index].score_desc}\n\n链接: {apiData.data[index].url}\n\n点击\"是\"选项，跳转链接\n点击\"否\"选项，留在此程序", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    Process.Start($"{apiData.data[index].url}");
                }
            }
        }
    }
}
