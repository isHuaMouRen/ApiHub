using ApiHub.apiForms;
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
using ApiHub.apiForms._60sAPI;

namespace ApiHub
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
        public static string Version = "Beta 1.4.2.7";

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
            public static class _60sAPI
            {
                public static string _60sReadworld;
                public static string bingWallpaper;
                public static string exchangeRate;
                public static string historyToday;
                public static string doyinHot;
                public static string rednoteHot;
                public static string biliHot;
                public static string weiboHot;
                public static string toutiaoHot;
                public static string zhihuHot;
                public static string baiduHot;
                public static string baiduTvHot;
                public static string baiduTiebaHot;
                public static string ncmList;
                public static string maoyanHot;
                public static string epicFreeGame;
            }
            
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
                    api_url = "cn1",
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

            APIURL._60sAPI._60sReadworld = $"{RootUrl}/v2/60s";
            APIURL._60sAPI.bingWallpaper = $"{RootUrl}/v2/bing";
            APIURL._60sAPI.exchangeRate = $"{RootUrl}/v2/exchange_rate";
            APIURL._60sAPI.historyToday = $"{RootUrl}/v2/today_in_history";
            APIURL._60sAPI.doyinHot = $"{RootUrl}/v2/douyin";
            APIURL._60sAPI.rednoteHot = $"{RootUrl}/v2/rednote";
            APIURL._60sAPI.biliHot = $"{RootUrl}/v2/bili";
            APIURL._60sAPI.weiboHot = $"{RootUrl}/v2/weibo";
            APIURL._60sAPI.toutiaoHot = $"{RootUrl}/v2/toutiao";
            APIURL._60sAPI.zhihuHot = $"{RootUrl}/v2/zhihu";
            APIURL._60sAPI.baiduHot = $"{RootUrl}/v2/baidu/realtime";
            APIURL._60sAPI.baiduTvHot = $"{RootUrl}/v2/baidu/teleplay";
            APIURL._60sAPI.baiduTiebaHot = $"{RootUrl}/v2/baidu/tieba";
            APIURL._60sAPI.ncmList = $"{RootUrl}/v2/ncm-rank";
            APIURL._60sAPI.maoyanHot = $"{RootUrl}/v2/maoyan";
            APIURL._60sAPI.epicFreeGame = $"{RootUrl}/v2/epic";
        }

        private void 关于程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ApiHub 快速查看60sAPI内容！\n\n版本: {Version}\n\n程序基于C# Winform .NET Framework 4.8\nAPI由60s API提供", "关于程序", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 项目仓库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/isHuaMouRen/ApiHub");
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

        public void ApiButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string tagName = $"{btn.Tag}";

            Form window = null;

            if (tagName == "60sReadWorld")
            {
                window = new _60sReadWorld();
            }
            else if (tagName == "BingWallpaper")
            {
                window = new bingWallpaper();
            }
            else if (tagName == "ExchangeRate")
            {
                window = new ExchangeRate();
            }
            else if (tagName == "HistoryToday")
            {
                window = new HistoryToday();
            }
            else if (tagName == "DoyinHot")
            {
                window = new DoyinHot();
            }
            else if (tagName == "RednoteHot")
            {
                window = new RednoteHot();
            }
            else if (tagName == "BiliHot")
            {
                window = new BiliHot();
            }
            else if (tagName == "WeiboHot")
            {
                window = new WeiboHot();
            }
            else if (tagName == "ToutiaoHot")
            {
                window = new ToutiaoHot();
            }
            else if (tagName == "ZhihuHot")
            {
                window = new ZhihuHot();
            }
            else if (tagName == "BaiduHot")
            {
                window = new BaiduHot();
            }
            else if (tagName == "BaiduTvHot")
            {
                window = new BaiduTvHot();
            }
            else if (tagName == "BaiduTiebaHot")
            {
                window = new BaiduTiebaHot();
            }
            else if (tagName == "NcmList")
            {
                window = new NcmList();
            }
            else if (tagName == "NcmListInfo")
            {
                window = new NcmListInfo();
            }
            else if (tagName == "MaoyanHot")
            {
                window = new MaoyanHot();
            }
            else if (tagName == "EpicFreeGame")
            {
                window = new EpicFreeGame();
            }

            else
            {
                window = null;
                MessageBox.Show($"传入了未知的参数\n\n问题由 {btn.Name} 引发", "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            if (window != null) window.ShowDialog();

        }

    }
}
