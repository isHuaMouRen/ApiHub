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
using Newtonsoft.Json;

namespace ApiHub.apiForms
{
    public partial class BiliHot : Form
    {
        public class API
        {
            public class Root
            {
                public int code { get; set; }
                public string message { get; set; }
                public API.Data[] data { get; set; }
            }

            public class Data
            {
                public string title { get; set; }
                public string link { get; set; }
            }
        }

        public static API.Root APIData;

        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;
                listView_main.Enabled = false;

                using (HttpClient client = new HttpClient())
                {
                    APIData = JsonConvert.DeserializeObject<API.Root>(await client.GetStringAsync(Main_Window.APIURL._60sAPI.biliHot)); 
                }

                if (APIData.code == 200)
                {
                    listView_main.Items.Clear();
                    for (int i = 0; i < APIData.data.Length; i++)
                    {
                        ListViewItem item = new ListViewItem($"{APIData.data[i].title}");
                        item.SubItems.Add($"{APIData.data[i].link}");
                        listView_main.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show($"发生API内部错误!\n\n错误代码: {APIData.code}\n错误信息: {APIData.message}", "API内部错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                button_Refresh.Enabled = true;
                listView_main.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                listView_main.Enabled = true;
                MessageBox.Show($"在获取API数据时发生错误\n\n错误原因:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        public BiliHot()
        {
            InitializeComponent();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void BiliHot_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void listView_main_ItemActivate(object sender, EventArgs e)
        {
            if (listView_main.SelectedItems.Count > 0)
            {
                if (MessageBox.Show($"{APIData.data[listView_main.SelectedIndices[0]].title}\n\n链接:\n{APIData.data[listView_main.SelectedIndices[0]].link}\n\n点击\"是\"按钮，前往链接\n点击\"否\"按钮，留在此程序", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    Process.Start(APIData.data[listView_main.SelectedIndices[0]].link);
                }
            }
        }

        private void BiliHot_Resize(object sender, EventArgs e)
        {
            button_Refresh.Left = this.Width - 147;

            listView_main.Size = new Size(this.Width - 45, this.Height - 123);
        }
    }
}
