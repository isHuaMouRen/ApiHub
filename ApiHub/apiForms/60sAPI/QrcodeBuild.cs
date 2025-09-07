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
    public partial class QrcodeBuild : Form
    {
        public string apiData { get; set; }

        public async void RefreshAPI()
        {
            try
            {
                button_Build.Enabled = false;
                button_Refresh.Enabled = false;
                button_Save.Enabled = false;
                textBox_Text.Enabled = false;
                numericUpDown_Size.Enabled = false;

                apiData = $"{Main_Window.APIURL._60sAPI.qrcodeBuild}?text={textBox_Text.Text}&size={numericUpDown_Size.Value}";

                using (HttpClient client = new HttpClient())
                {
                    Stream stream = await client.GetStreamAsync(apiData);
                    pictureBox_Qrcode.Image = Image.FromStream(stream);
                }

                button_Build.Enabled = true;
                button_Refresh.Enabled = true;
                button_Save.Enabled = true;
                textBox_Text.Enabled = true;
                numericUpDown_Size.Enabled = true;
            }
            catch (Exception ex)
            {
                button_Build.Enabled = true;
                button_Refresh.Enabled = true;
                button_Save.Enabled = true;
                textBox_Text.Enabled = true;
                numericUpDown_Size.Enabled = true;
                MessageBox.Show($"获取API数据流时发生错误\n\n错误:\n{ex}", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public QrcodeBuild()
        {
            InitializeComponent();
        }

        private void button_Build_Click(object sender, EventArgs e)
        {
            RefreshAPI();

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (apiData == null)
            {
                MessageBox.Show($"请先生成一个二维码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(apiData);
            }
        }
    }
}
