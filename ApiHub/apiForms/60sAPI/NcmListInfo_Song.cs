using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiHub.apiForms._60sAPI
{
    public partial class NcmListInfo_Song : Form
    {
        public NcmListInfo_Song()
        {
            InitializeComponent();
        }

        private async void NcmListInfo_Song_Load(object sender, EventArgs e)
        {
            linkLabel_Title.Text = NcmListInfo.apiData.data[NcmListInfo.selectIndex].title;
            linkLabel_Album.Text = $"专辑: {NcmListInfo.apiData.data[NcmListInfo.selectIndex].album.name}";
            label_Time.Text = $"时长: {NcmListInfo.apiData.data[NcmListInfo.selectIndex].duration_desc}";
            label_Size.Text = $"大小:  SQ: {NcmListInfo.apiData.data[NcmListInfo.selectIndex].mb.sq.size_desc}  HQ: {NcmListInfo.apiData.data[NcmListInfo.selectIndex].mb.hq.size_desc}  MQ: {NcmListInfo.apiData.data[NcmListInfo.selectIndex].mb.mq.size_desc}  LQ: {NcmListInfo.apiData.data[NcmListInfo.selectIndex].mb.lq.size_desc}";


            using (HttpClient client = new HttpClient())
            {
                Stream stream = await client.GetStreamAsync($"{NcmListInfo.apiData.data[NcmListInfo.selectIndex].album.cover}");

                pictureBox_Cover.Image = Image.FromStream(stream);
            }

            listView_Artist.Items.Clear();
            for (int i = 0; i < NcmListInfo.apiData.data[NcmListInfo.selectIndex].artist.Length; i++)
            {
                ListViewItem item = new ListViewItem($"{NcmListInfo.apiData.data[NcmListInfo.selectIndex].artist[i].name}");
                listView_Artist.Items.Add(item);
            }
            
        }

        private void linkLabel_Album_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start($"https://music.163.com/#/album?id={NcmListInfo.apiData.data[NcmListInfo.selectIndex].album.id}");
        }

        private void linkLabel_Title_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start($"{NcmListInfo.apiData.data[NcmListInfo.selectIndex].link}");
        }
    }
}
