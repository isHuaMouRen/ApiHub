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
    public partial class ExchangeRate : Form
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
                public string base_code { get; set; }
                public string updated { get; set; }
                public string next_updated { get; set; }
                public API.ExchangeRate[] rates { get; set; }
            }

            public class ExchangeRate
            {
                public string currency { get; set; }
                public double rate { get; set; }
            }
        }

        public static API.Root APIData;

        public async void RefreshAPI()
        {
            try
            {
                button_Refresh.Enabled = false;
                button_Search.Enabled = false;
                textBox_Search.Enabled = false;

                using (HttpClient client = new HttpClient())
                {
                    File.WriteAllText(Main_Window.TempPath, await client.GetStringAsync(Main_Window.APIURL.exchangeRate));
                    APIData = ReadJson<API.Root>(Main_Window.TempPath); 
                }

                if (APIData.code == 200)
                {
                    listView_main.Items.Clear();

                    for (int i = 0; i < APIData.data.rates.Length; i++)
                    {
                        ListViewItem item = new ListViewItem(APIData.data.rates[i].currency);
                        item.SubItems.Add(APIData.data.rates[i].rate + "");
                        listView_main.Items.Add(item);
                    }

                    textBox_Search.Text = APIData.data.rates[1].currency;
                }
                else
                {
                    MessageBox.Show($"发生API内部错误\n\n错误代码: {APIData.code}\n错误信息: {APIData.message}", "API内部错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                    button_Refresh.Enabled = true;
                button_Search.Enabled = true;
                textBox_Search.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                button_Search.Enabled = true;
                textBox_Search.Enabled = true;

                MessageBox.Show($"在获取API数据时发生错误!\n\n错误原因:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



















        public ExchangeRate()
        {
            InitializeComponent();
        }

        private void ExchangeRate_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void linkLabel_GoWebside_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://coinyep.com/zh/currencies");
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView_main.Items.Count; i++)
            {
                if (textBox_Search.Text == listView_main.Items[i].Text)
                {
                    listView_main.Items[i].Selected = true;
                    listView_main.Items[i].EnsureVisible();

                    return;
                }
            }

            MessageBox.Show("没有匹配的项目!\n\n尝试全字匹配", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void ExchangeRate_Resize(object sender, EventArgs e)
        {
            listView_main.Size = new Size(this.Width - 44, this.Height - 154);
            button_Refresh.Left = this.Width - 142;
            linkLabel_GoWebside.Left = this.Width - 116;

            textBox_Search.Top = this.Height - 76;
            button_Search.Top = this.Height - 76;

            button_Search.Left = this.Width - 103;
            textBox_Search.Width = this.Width - 125;
        }
    }
}
