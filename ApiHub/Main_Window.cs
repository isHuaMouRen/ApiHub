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
using System.Net.Http;

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
                    public JsonConfig.Config.ApiUrls ApiURLs { get; set; }
                }

                public class ApiUrls
                {
                    public string _60sAPI { get; set; }
                }
            }

            public class PublicIP
            {
                public class Root
                {
                    public int code { get; set; }
                    public string message { get; set; }
                    public JsonConfig.PublicIP.Data data { get; set; }
                }

                public class Data
                {
                    public string ip { get; set; }
                }
            }
        }
        //变量========================================================================================
        public static string RunPath = Directory.GetCurrentDirectory();
        public static string ConfigPath = $"{RunPath}\\config.json";
        public static string TempPath = $"{Path.GetTempPath()}apitemp.json";
        public static string RootUrl = "https://60s.viki.moe";
        public static string Version = "Beta 1.5.2.5";

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
                public static string qrcodeBuild;
                public static string baikeSearch;
                public static string fanyi;
                public static string fanyiList;
                public static string publicIP;
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
                    ApiURLs = new JsonConfig.Config.ApiUrls
                    {
                        _60sAPI = "cn1"
                    }
                };

                WriteJson<JsonConfig.Config.Root>(ConfigPath, GlobalConfig);
            }


            //读配置
            GlobalConfig = ReadJson<JsonConfig.Config.Root>(ConfigPath);

            if (GlobalConfig.ApiURLs._60sAPI == "main")
            {
                RootUrl = APIRootURL.main;
            }
            else if (GlobalConfig.ApiURLs._60sAPI == "sub1")
            {
                RootUrl = APIRootURL.sub1;
            }
            else if (GlobalConfig.ApiURLs._60sAPI == "sub2")
            {
                RootUrl = APIRootURL.sub2;
            }
            else if (GlobalConfig.ApiURLs._60sAPI == "cn1")
            {
                RootUrl = APIRootURL.cn1;
            }
            else if (GlobalConfig.ApiURLs._60sAPI == "cn2")
            {
                RootUrl = APIRootURL.cn2;
            }
            else
            {
                MessageBox.Show($"在读取配置文件时发现了非法的值\n\n位置:\nRoot -> ApiURLs._60sAPI\n值: {GlobalConfig.ApiURLs._60sAPI}\n\n已将其改为默认值", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GlobalConfig.ApiURLs._60sAPI = "cn1";
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
            APIURL._60sAPI.qrcodeBuild = $"{RootUrl}/v2/qrcode";
            APIURL._60sAPI.baikeSearch = $"{RootUrl}/v2/baike";
            APIURL._60sAPI.fanyi = $"{RootUrl}/v2/fanyi";
            APIURL._60sAPI.fanyiList = $"{RootUrl}/v2/fanyi/langs";
            APIURL._60sAPI.publicIP = $"{RootUrl}/v2/ip";
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

        public async void ApiButton_Click(object sender, EventArgs e)
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
            else if (tagName == "QrcodeBuild")
            {
                window = new QrcodeBuild();
            }
            else if (tagName == "BaikeSearch")
            {
                window = new BaikeSearch();
            }
            else if (tagName == "Fanyi")
            {
                window = new Fanyi();
            }
            else if (tagName == "PublicIP")
            {
                
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        File.WriteAllText(TempPath, await client.GetStringAsync(APIURL._60sAPI.publicIP));
                        JsonConfig.PublicIP.Root apiData = ReadJson<JsonConfig.PublicIP.Root>(TempPath);

                        if (apiData.code == 200)
                        {
                            MessageBox.Show($"API数据获取成功!\n\n公网IP地址: {apiData.data.ip}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"---Internal error of API---\n\nError code: {apiData.code}\nError message: {apiData.message}", "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"---Error report---\n\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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
