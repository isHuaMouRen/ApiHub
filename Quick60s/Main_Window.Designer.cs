namespace Quick60s
{
    partial class Main_Window
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_BingWallpaper = new System.Windows.Forms.Panel();
            this.button_BingWallpaper_Go = new System.Windows.Forms.Button();
            this.label_BingWallpaper_Subtitle = new System.Windows.Forms.Label();
            this.label_BingWallpaper_Title = new System.Windows.Forms.Label();
            this.panel_60sReadWorld = new System.Windows.Forms.Panel();
            this.button_60sReadWorld_Go = new System.Windows.Forms.Button();
            this.label_60sReadWorld_Content = new System.Windows.Forms.Label();
            this.label_60sReadWorld_Title = new System.Windows.Forms.Label();
            this.panel_ExchangeRate = new System.Windows.Forms.Panel();
            this.button_ExchangeRate = new System.Windows.Forms.Button();
            this.label_ExchangeRate_Subtitle = new System.Windows.Forms.Label();
            this.label_ExchangeRate_Title = new System.Windows.Forms.Label();
            this.panel_HistoryToday = new System.Windows.Forms.Panel();
            this.button_HistoryToday_Go = new System.Windows.Forms.Button();
            this.label_HistoryToday_Subtitle = new System.Windows.Forms.Label();
            this.label_HistoryToday_Title = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_BingWallpaper.SuspendLayout();
            this.panel_60sReadWorld.SuspendLayout();
            this.panel_ExchangeRate.SuspendLayout();
            this.panel_HistoryToday.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.panel_HistoryToday);
            this.panel_main.Controls.Add(this.panel_ExchangeRate);
            this.panel_main.Controls.Add(this.panel_BingWallpaper);
            this.panel_main.Controls.Add(this.panel_60sReadWorld);
            this.panel_main.Location = new System.Drawing.Point(12, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(760, 337);
            this.panel_main.TabIndex = 1;
            // 
            // panel_BingWallpaper
            // 
            this.panel_BingWallpaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_BingWallpaper.Controls.Add(this.button_BingWallpaper_Go);
            this.panel_BingWallpaper.Controls.Add(this.label_BingWallpaper_Subtitle);
            this.panel_BingWallpaper.Controls.Add(this.label_BingWallpaper_Title);
            this.panel_BingWallpaper.Location = new System.Drawing.Point(380, 3);
            this.panel_BingWallpaper.Name = "panel_BingWallpaper";
            this.panel_BingWallpaper.Size = new System.Drawing.Size(375, 110);
            this.panel_BingWallpaper.TabIndex = 1;
            // 
            // button_BingWallpaper_Go
            // 
            this.button_BingWallpaper_Go.Location = new System.Drawing.Point(7, 73);
            this.button_BingWallpaper_Go.Name = "button_BingWallpaper_Go";
            this.button_BingWallpaper_Go.Size = new System.Drawing.Size(363, 32);
            this.button_BingWallpaper_Go.TabIndex = 2;
            this.button_BingWallpaper_Go.Text = "前往";
            this.button_BingWallpaper_Go.UseVisualStyleBackColor = true;
            this.button_BingWallpaper_Go.Click += new System.EventHandler(this.button_BingWallpaper_Go_Click);
            // 
            // label_BingWallpaper_Subtitle
            // 
            this.label_BingWallpaper_Subtitle.Location = new System.Drawing.Point(4, 30);
            this.label_BingWallpaper_Subtitle.Name = "label_BingWallpaper_Subtitle";
            this.label_BingWallpaper_Subtitle.Size = new System.Drawing.Size(192, 40);
            this.label_BingWallpaper_Subtitle.TabIndex = 1;
            this.label_BingWallpaper_Subtitle.Text = "每日精美壁纸\r\n来源: Bing官方";
            this.label_BingWallpaper_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_BingWallpaper_Title
            // 
            this.label_BingWallpaper_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_BingWallpaper_Title.Location = new System.Drawing.Point(3, 6);
            this.label_BingWallpaper_Title.Name = "label_BingWallpaper_Title";
            this.label_BingWallpaper_Title.Size = new System.Drawing.Size(287, 20);
            this.label_BingWallpaper_Title.TabIndex = 0;
            this.label_BingWallpaper_Title.Text = "[日更] 必应每日壁纸";
            this.label_BingWallpaper_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_60sReadWorld
            // 
            this.panel_60sReadWorld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_60sReadWorld.Controls.Add(this.button_60sReadWorld_Go);
            this.panel_60sReadWorld.Controls.Add(this.label_60sReadWorld_Content);
            this.panel_60sReadWorld.Controls.Add(this.label_60sReadWorld_Title);
            this.panel_60sReadWorld.Location = new System.Drawing.Point(3, 3);
            this.panel_60sReadWorld.Name = "panel_60sReadWorld";
            this.panel_60sReadWorld.Size = new System.Drawing.Size(375, 110);
            this.panel_60sReadWorld.TabIndex = 0;
            // 
            // button_60sReadWorld_Go
            // 
            this.button_60sReadWorld_Go.Location = new System.Drawing.Point(7, 73);
            this.button_60sReadWorld_Go.Name = "button_60sReadWorld_Go";
            this.button_60sReadWorld_Go.Size = new System.Drawing.Size(363, 32);
            this.button_60sReadWorld_Go.TabIndex = 2;
            this.button_60sReadWorld_Go.Text = "前往";
            this.button_60sReadWorld_Go.UseVisualStyleBackColor = true;
            this.button_60sReadWorld_Go.Click += new System.EventHandler(this.button_60sReadWorld_Go_Click);
            // 
            // label_60sReadWorld_Content
            // 
            this.label_60sReadWorld_Content.Location = new System.Drawing.Point(4, 30);
            this.label_60sReadWorld_Content.Name = "label_60sReadWorld_Content";
            this.label_60sReadWorld_Content.Size = new System.Drawing.Size(137, 40);
            this.label_60sReadWorld_Content.TabIndex = 1;
            this.label_60sReadWorld_Content.Text = "每日精选新闻摘要\r\n来源: 微信公众号";
            this.label_60sReadWorld_Content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_60sReadWorld_Title
            // 
            this.label_60sReadWorld_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_60sReadWorld_Title.Location = new System.Drawing.Point(3, 6);
            this.label_60sReadWorld_Title.Name = "label_60sReadWorld_Title";
            this.label_60sReadWorld_Title.Size = new System.Drawing.Size(287, 20);
            this.label_60sReadWorld_Title.TabIndex = 0;
            this.label_60sReadWorld_Title.Text = "[日更] 每天60秒读懂世界";
            this.label_60sReadWorld_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_ExchangeRate
            // 
            this.panel_ExchangeRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ExchangeRate.Controls.Add(this.button_ExchangeRate);
            this.panel_ExchangeRate.Controls.Add(this.label_ExchangeRate_Subtitle);
            this.panel_ExchangeRate.Controls.Add(this.label_ExchangeRate_Title);
            this.panel_ExchangeRate.Location = new System.Drawing.Point(3, 119);
            this.panel_ExchangeRate.Name = "panel_ExchangeRate";
            this.panel_ExchangeRate.Size = new System.Drawing.Size(375, 110);
            this.panel_ExchangeRate.TabIndex = 2;
            // 
            // button_ExchangeRate
            // 
            this.button_ExchangeRate.Location = new System.Drawing.Point(7, 73);
            this.button_ExchangeRate.Name = "button_ExchangeRate";
            this.button_ExchangeRate.Size = new System.Drawing.Size(363, 32);
            this.button_ExchangeRate.TabIndex = 2;
            this.button_ExchangeRate.Text = "前往";
            this.button_ExchangeRate.UseVisualStyleBackColor = true;
            this.button_ExchangeRate.Click += new System.EventHandler(this.button_ExchangeRate_Click);
            // 
            // label_ExchangeRate_Subtitle
            // 
            this.label_ExchangeRate_Subtitle.Location = new System.Drawing.Point(4, 30);
            this.label_ExchangeRate_Subtitle.Name = "label_ExchangeRate_Subtitle";
            this.label_ExchangeRate_Subtitle.Size = new System.Drawing.Size(137, 40);
            this.label_ExchangeRate_Subtitle.TabIndex = 1;
            this.label_ExchangeRate_Subtitle.Text = "实时货币汇率\r\n来源: 权威金融数据";
            this.label_ExchangeRate_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ExchangeRate_Title
            // 
            this.label_ExchangeRate_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ExchangeRate_Title.Location = new System.Drawing.Point(3, 6);
            this.label_ExchangeRate_Title.Name = "label_ExchangeRate_Title";
            this.label_ExchangeRate_Title.Size = new System.Drawing.Size(287, 20);
            this.label_ExchangeRate_Title.TabIndex = 0;
            this.label_ExchangeRate_Title.Text = "[日更] 当日货币汇率";
            this.label_ExchangeRate_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_HistoryToday
            // 
            this.panel_HistoryToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_HistoryToday.Controls.Add(this.button_HistoryToday_Go);
            this.panel_HistoryToday.Controls.Add(this.label_HistoryToday_Subtitle);
            this.panel_HistoryToday.Controls.Add(this.label_HistoryToday_Title);
            this.panel_HistoryToday.Location = new System.Drawing.Point(380, 119);
            this.panel_HistoryToday.Name = "panel_HistoryToday";
            this.panel_HistoryToday.Size = new System.Drawing.Size(375, 110);
            this.panel_HistoryToday.TabIndex = 3;
            // 
            // button_HistoryToday_Go
            // 
            this.button_HistoryToday_Go.Location = new System.Drawing.Point(7, 73);
            this.button_HistoryToday_Go.Name = "button_HistoryToday_Go";
            this.button_HistoryToday_Go.Size = new System.Drawing.Size(363, 32);
            this.button_HistoryToday_Go.TabIndex = 2;
            this.button_HistoryToday_Go.Text = "前往";
            this.button_HistoryToday_Go.UseVisualStyleBackColor = true;
            this.button_HistoryToday_Go.Click += new System.EventHandler(this.button_HistoryToday_Go_Click);
            // 
            // label_HistoryToday_Subtitle
            // 
            this.label_HistoryToday_Subtitle.Location = new System.Drawing.Point(4, 30);
            this.label_HistoryToday_Subtitle.Name = "label_HistoryToday_Subtitle";
            this.label_HistoryToday_Subtitle.Size = new System.Drawing.Size(137, 40);
            this.label_HistoryToday_Subtitle.TabIndex = 1;
            this.label_HistoryToday_Subtitle.Text = "历史上的今天\r\n来源: 权威历史资料";
            this.label_HistoryToday_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_HistoryToday_Title
            // 
            this.label_HistoryToday_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_HistoryToday_Title.Location = new System.Drawing.Point(3, 6);
            this.label_HistoryToday_Title.Name = "label_HistoryToday_Title";
            this.label_HistoryToday_Title.Size = new System.Drawing.Size(287, 20);
            this.label_HistoryToday_Title.TabIndex = 0;
            this.label_HistoryToday_Title.Text = "[日更] 历史上的今天";
            this.label_HistoryToday_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick60s";
            this.panel_main.ResumeLayout(false);
            this.panel_BingWallpaper.ResumeLayout(false);
            this.panel_60sReadWorld.ResumeLayout(false);
            this.panel_ExchangeRate.ResumeLayout(false);
            this.panel_HistoryToday.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_60sReadWorld;
        private System.Windows.Forms.Label label_60sReadWorld_Title;
        private System.Windows.Forms.Label label_60sReadWorld_Content;
        private System.Windows.Forms.Button button_60sReadWorld_Go;
        private System.Windows.Forms.Panel panel_BingWallpaper;
        private System.Windows.Forms.Button button_BingWallpaper_Go;
        private System.Windows.Forms.Label label_BingWallpaper_Subtitle;
        private System.Windows.Forms.Label label_BingWallpaper_Title;
        private System.Windows.Forms.Panel panel_ExchangeRate;
        private System.Windows.Forms.Button button_ExchangeRate;
        private System.Windows.Forms.Label label_ExchangeRate_Subtitle;
        private System.Windows.Forms.Label label_ExchangeRate_Title;
        private System.Windows.Forms.Panel panel_HistoryToday;
        private System.Windows.Forms.Button button_HistoryToday_Go;
        private System.Windows.Forms.Label label_HistoryToday_Subtitle;
        private System.Windows.Forms.Label label_HistoryToday_Title;
    }
}

