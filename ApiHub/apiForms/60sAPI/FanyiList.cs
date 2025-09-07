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
    public partial class FanyiList : Form
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
                public string code { get; set; }
                public string label { get; set; }
                public string alphabet { get; set; }
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
                    File.WriteAllText(Main_Window.TempPath, await client.GetStringAsync(Main_Window.APIURL._60sAPI.fanyiList));
                    apiData = Funcitons.NormalFunc.ReadJson<JsonConfig.Root>(Main_Window.TempPath);
                }

                if (apiData.code == 200)
                {
                    listView1.Items.Clear();
                    for (int i = 0; i < apiData.data.Length; i++)
                    {
                        ListViewItem item = new ListViewItem($"{apiData.data[i].label}");
                        item.SubItems.Add($"{apiData.data[i].code}");
                        item.SubItems.Add($"{apiData.data[i].alphabet}");

                        listView1.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show($"Internal error of API\n\nError code: {apiData.code}\nError message: {apiData.message}", "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                    button_Refresh.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Refresh.Enabled = true;
                MessageBox.Show($"--Error Report--\n\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        public FanyiList()
        {
            InitializeComponent();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void FanyiList_Load(object sender, EventArgs e)
        {
            RefreshAPI();
        }
    }
}
