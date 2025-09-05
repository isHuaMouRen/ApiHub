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
using static Funcitons.NormalFunc;

namespace ApiHub.apiForms
{
    public partial class HistoryToday : Form
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
                public API.Event[] items { get; set; }
            }

            public class Event
            {
                public string title { get; set; }
                public string year { get; set; }
                public string description { get; set; }
                public string event_type { get; set; }
            }
        }

        public API.Root APIData;

        public async void RefreshAPI()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    File.WriteAllText(Main_Window.TempPath, await client.GetStringAsync(Main_Window.APIURL.historyToday));
                    APIData = ReadJson<API.Root>(Main_Window.TempPath);
                }

                if (APIData.code == 200)
                {
                    label_Date.Text = $"日期: {APIData.data.date}";

                    listView_main.Items.Clear();
                    for (int i = 0; i < APIData.data.items.Length; i++)
                    {
                        ListViewItem item = new ListViewItem($"{APIData.data.items[i].title}");
                        item.SubItems.Add($"{APIData.data.items[i].year}");
                        item.SubItems.Add($"{APIData.data.items[i].description}");

                        if (APIData.data.items[i].event_type == "event")
                        {
                            item.SubItems.Add($"事件");
                        }
                        else if (APIData.data.items[i].event_type == "death")
                        {
                            item.SubItems.Add("逝世");
                        }
                        else if (APIData.data.items[i].event_type== "birth")
                        {
                            item.SubItems.Add("出生");
                        }
                        else
                        {
                            item.SubItems.Add("未知");
                        }

                        listView_main.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show($"发生API内部错误!\n\n错误代码: {APIData.code}\n错误信息: {APIData.message}", "API内部错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"在获取API数据时发生错误!\n\n错误原因:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        public HistoryToday()
        {
            InitializeComponent();
        }

        private void HistoryToday_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void listView_main_ItemActivate(object sender, EventArgs e)
        {
            if (listView_main.SelectedItems.Count > 0)
            {
                MessageBox.Show($"{APIData.data.items[listView_main.SelectedIndices[0]].title}\n\n{APIData.data.items[listView_main.SelectedIndices[0]].description}", "详细信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void HistoryToday_Resize(object sender, EventArgs e)
        {
            listView_main.Size = new Size(this.Width - 46, this.Height - 146);
        }
    }
}
