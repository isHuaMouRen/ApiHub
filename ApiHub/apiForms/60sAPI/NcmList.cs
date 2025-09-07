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

namespace ApiHub.apiForms._60sAPI
{
    public partial class NcmList : Form
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
                public string name { get; set; }
                public string description { get; set; }
                public string updated { get; set; }
                public string link { get; set; }
            }
        }

        public JsonConfig.Root apiData;

        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;
                listView_main.Enabled = false;

                using (HttpClient client = new HttpClient())
                {
                    File.WriteAllText(Main_Window.TempPath, await client.GetStringAsync(Main_Window.APIURL._60sAPI.ncmList));
                    apiData = NormalFunc.ReadJson<JsonConfig.Root>(Main_Window.TempPath);
                }

                if (apiData.code == 200)
                {
                    listView_main.Items.Clear();
                    for (int i = 0; i < apiData.data.Length; i++)
                    {
                        ListViewItem item = new ListViewItem($"{apiData.data[i].name}");
                        item.SubItems.Add($"{apiData.data[i].id}");
                        item.SubItems.Add($"{apiData.data[i].description}");
                        item.SubItems.Add($"{apiData.data[i].updated}");

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




        public Size minSize;

        public NcmList()
        {
            InitializeComponent();

            minSize = this.Size - listView_main.Size;
        }

        private void NcmList_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void NcmList_Resize(object sender, EventArgs e)
        {
            listView_main.Size = this.Size - minSize;
        }

        private void listView_main_ItemActivate(object sender, EventArgs e)
        {
            int index = listView_main.SelectedIndices[0];

            if (MessageBox.Show($"{apiData.data[index].name}\n\n{apiData.data[index].description}\n\n\n链接: {apiData.data[index].link}\n\n选择\"是\"跳转链接\n选择\"否\"留在程序", "详细信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Process.Start($"{apiData.data[index].link}");
            }
        }
    }
}
