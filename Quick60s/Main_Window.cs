using Quick60s.apiForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funcitons;
using static Funcitons.NormalFunc;
using System.Diagnostics;

namespace Quick60s
{
    public partial class Main_Window : Form
    {
        //函数========================================================================================
        //Json======================================================================================
        public class JsonConfig
        {
            public class Config
            {
                public class Root
                {
                    public string api_url { get; set; }
                }
            }
        }
        //变量========================================================================================
        public static string RunPath = Directory.GetCurrentDirectory();
        public static string ConfigPath = $"{RunPath}\\config.json";
        public static string TempPath = $"{Path.GetTempPath()}apitemp.json";
        public static string RootUrl = "https://60s.viki.moe";
        public static string Version = "Beta 1.1.2.4";
        public static string BuildDate = "2025-9-3 15:12";

        public static JsonConfig.Config.Root GlobalConfig;

        //API根地址
        public static class APIRootURL
        {
            public static readonly string main = "https://60s.viki.moe";
            public static readonly string sub1 = "https://60s.b23.run";
            public static readonly string sub2 = "https://60s.114128.xyz";
            public static readonly string cn1 = "https://60s-cf.viki.moe/";
            public static readonly string cn2 = "https://60s-cf.114128.xyz/";
        }

        //API地址
        public static class APIURL
        {
            public static string _60sReadworld;
            public static string bingWallpaper;
            public static string exchangeRate;
            public static string historyToday;
            public static string doyinHot;
            public static string rednoteHot;
        }


        //事件========================================================================================
        public Main_Window()
        {
            InitializeComponent();

            //写配置
            if (!File.Exists(ConfigPath))
            {
                GlobalConfig = new JsonConfig.Config.Root
                {
                    api_url = "cn1"
                };

                WriteJson<JsonConfig.Config.Root>(ConfigPath, GlobalConfig);
            }


            //读配置
            GlobalConfig = ReadJson<JsonConfig.Config.Root>(ConfigPath);

            if (GlobalConfig.api_url == "main")
            {
                RootUrl = APIRootURL.main;
            }
            else if (GlobalConfig.api_url == "sub1")
            {
                RootUrl = APIRootURL.sub1;
            }
            else if (GlobalConfig.api_url == "sub2")
            {
                RootUrl = APIRootURL.sub2;
            }
            else if (GlobalConfig.api_url == "cn1")
            {
                RootUrl = APIRootURL.cn1;
            }
            else if (GlobalConfig.api_url == "cn2")
            {
                RootUrl = APIRootURL.cn2;
            }
            else
            {
                MessageBox.Show($"在读取配置文件时发现了非法的值\n\n位置:\nRoot -> api_url\n值: {GlobalConfig.api_url}\n\n已将其改为默认值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GlobalConfig.api_url = "cn1";
                WriteJson(ConfigPath, GlobalConfig);
            }


            APIURL._60sReadworld = $"{RootUrl}/v2/60s";
            APIURL.bingWallpaper = $"{RootUrl}/v2/bing";
            APIURL.exchangeRate = $"{RootUrl}/v2/exchange_rate";
            APIURL.historyToday = $"{RootUrl}/v2/today_in_history";
            APIURL.doyinHot = $"{RootUrl}/v2/douyin";
            APIURL.rednoteHot = $"{RootUrl}/v2/rednote";
        }

        private void button_60sReadWorld_Go_Click(object sender, EventArgs e)
        {
            using (_60sReadWorld window = new _60sReadWorld())
            {
                window.ShowDialog();
            }
        }

        private void button_BingWallpaper_Go_Click(object sender, EventArgs e)
        {
            using (bingWallpaper window = new bingWallpaper())
            {
                window.ShowDialog();
            }
        }

        private void button_ExchangeRate_Click(object sender, EventArgs e)
        {
            using (ExchangeRate window = new ExchangeRate())
            {
                window.ShowDialog();
            }
        }

        private void button_HistoryToday_Go_Click(object sender, EventArgs e)
        {
            using (HistoryToday window = new HistoryToday())
            {
                window.ShowDialog();
            }
        }

        private void button_DoyinHot_Go_Click(object sender, EventArgs e)
        {
            using (DoyinHot window = new DoyinHot())
            {
                window.ShowDialog();
            }
        }

        private void 关于程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Quick60s 快速查看60sAPI内容！\n\n版本: {Version}\n构建时间: {BuildDate}\n\n程序基于C# Winform .NET Framework 4.8\nAPI由60s API提供", "关于程序", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 项目仓库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/isHuaMouRen/Quick60s");
        }

        private void aPI仓库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/vikiboss/60s");
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Settings window = new Settings())
            {
                window.ShowDialog();
            }
        }

        private void button_RednoteHot_Go_Click(object sender, EventArgs e)
        {
            using (RednoteHot window = new RednoteHot())
            {
                window.ShowDialog();
            }
        }
    }
}
