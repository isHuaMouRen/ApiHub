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
    public partial class MaoyanHot : Form
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
                public JsonConfig.List[] list { get; set; }
                public string tip { get; set; }
                public string update_time { get; set; }
            }

            public class List
            {
                public long maoyan_id { get; set; }
                public string movie_name { get; set; }
                public string release_year { get; set; }
                public string box_office_desc { get; set; }
            }
        }

        public JsonConfig.Root apiData;

        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;

                using (HttpClient client = new HttpClient())
                {
                    File.WriteAllText(Main_Window.TempPath, await client.GetStringAsync(Main_Window.APIURL._60sAPI.maoyanHot));
                    apiData = Funcitons.NormalFunc.ReadJson<JsonConfig.Root>(Main_Window.TempPath);
                }

                if (apiData.code == 200)
                {
                    listView_main.Items.Clear();
                    for (int i = 0; i < apiData.data.list.Length; i++)
                    {
                        ListViewItem item = new ListViewItem($"{apiData.data.list[i].movie_name}");
                        item.SubItems.Add($"{apiData.data.list[i].release_year}");
                        item.SubItems.Add($"{apiData.data.list[i].box_office_desc}");
                        item.SubItems.Add($"{apiData.data.list[i].maoyan_id}");
                        listView_main.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show($"发生了API内部错误\n\n错误代码: {apiData.code}\n错误信息: {apiData.message}", "API内部错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                button_Refresh.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                MessageBox.Show($"在获取API数据时发生错误\n\n错误原因:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        public Size minSize;

        public MaoyanHot()
        {
            InitializeComponent();

            minSize = this.Size - listView_main.Size;
        }

        private void MaoyanHot_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void MaoyanHot_Resize(object sender, EventArgs e)
        {
            listView_main.Size = this.Size - minSize;
        }
    }
}
