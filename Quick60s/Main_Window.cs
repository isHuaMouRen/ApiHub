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

namespace Quick60s
{
    public partial class Main_Window : Form
    {
        //函数========================================================================================
        //Json======================================================================================
        /*public class JsonConfig
        {
            public class Config
            {
                public class Root
                {

                }
            }
        }*/
        //变量========================================================================================
        public static string RunPath = Directory.GetCurrentDirectory();
        public static string ConfigPath = $"{RunPath}\\config.json";
        public static string TempPath = $"{Path.GetTempPath()}apitemp.json";
        public static string APIRootUrl = "https://60s.viki.moe";

        //public static JsonConfig.Config.Root GlobalConfig;

        //API地址
        public static class APIURL
        {
            public static readonly string _60sReadworld = $"{APIRootUrl}/v2/60s";
            public static readonly string bingWallpaper = $"{APIRootUrl}/v2/bing";
            public static readonly string exchangeRate = $"{APIRootUrl}/v2/exchange_rate";
            public static readonly string historyToday = $"{APIRootUrl}/v2/today_in_history";
        }
        //事件========================================================================================
        public Main_Window()
        {
            InitializeComponent();

            /*if (!File.Exists(ConfigPath))
            {

                WriteJson<JsonConfig.Config.Root>(ConfigPath, GlobalConfig);
            }



            GlobalConfig = ReadJson<JsonConfig.Config.Root>(ConfigPath);*/
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
    }
}
