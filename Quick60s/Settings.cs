using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Funcitons.NormalFunc;

namespace Quick60s
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            if (Main_Window.GlobalConfig.api_url == "main")
            {
                comboBox_api_url.SelectedIndex = 0;
            }
            else if (Main_Window.GlobalConfig.api_url == "sub1")
            {
                comboBox_api_url.SelectedIndex = 1;
            }
            else if (Main_Window.GlobalConfig.api_url == "sub2")
            {
                comboBox_api_url.SelectedIndex = 2;
            }
            else if (Main_Window.GlobalConfig.api_url == "cn1")
            {
                comboBox_api_url.SelectedIndex = 3;
            }
            else if (Main_Window.GlobalConfig.api_url == "cn2")
            {
                comboBox_api_url.SelectedIndex = 4;
            }
        }

        private void button_SaveAndBack_Click(object sender, EventArgs e)
        {
            if (comboBox_api_url.SelectedIndex == 0)
            {
                Main_Window.GlobalConfig.api_url = "main";
            }
            else if (comboBox_api_url.SelectedIndex == 1)
            {
                Main_Window.GlobalConfig.api_url = "sub1";
            }
            else if (comboBox_api_url.SelectedIndex == 2)
            {
                Main_Window.GlobalConfig.api_url = "sub2";
            }
            else if (comboBox_api_url.SelectedIndex == 3)
            {
                Main_Window.GlobalConfig.api_url = "cn1";
            }
            else if (comboBox_api_url.SelectedIndex == 4)
            {
                Main_Window.GlobalConfig.api_url = "cn2";
            }


            WriteJson(Main_Window.ConfigPath, Main_Window.GlobalConfig);
            
            this.Close();
        }
    }
}
