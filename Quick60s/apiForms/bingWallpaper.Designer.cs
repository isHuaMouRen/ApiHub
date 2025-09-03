namespace Quick60s.apiForms
{
    partial class bingWallpaper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_overview = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Subtitle = new System.Windows.Forms.Label();
            this.label_image_title = new System.Windows.Forms.Label();
            this.label_image_headline = new System.Windows.Forms.Label();
            this.button_Download1080p = new System.Windows.Forms.Button();
            this.button_Download4K = new System.Windows.Forms.Button();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_overview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_overview
            // 
            this.pictureBox_overview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_overview.Location = new System.Drawing.Point(12, 62);
            this.pictureBox_overview.Name = "pictureBox_overview";
            this.pictureBox_overview.Size = new System.Drawing.Size(400, 225);
            this.pictureBox_overview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_overview.TabIndex = 0;
            this.pictureBox_overview.TabStop = false;
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(210, 30);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "[日更] 必应每日壁纸";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Subtitle
            // 
            this.label_Subtitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Subtitle.Location = new System.Drawing.Point(12, 39);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.Size = new System.Drawing.Size(400, 20);
            this.label_Subtitle.TabIndex = 2;
            this.label_Subtitle.Text = "每日精美壁纸";
            this.label_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_image_title
            // 
            this.label_image_title.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_image_title.Location = new System.Drawing.Point(7, 290);
            this.label_image_title.Name = "label_image_title";
            this.label_image_title.Size = new System.Drawing.Size(400, 20);
            this.label_image_title.TabIndex = 3;
            this.label_image_title.Text = "正在获取...";
            this.label_image_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_image_headline
            // 
            this.label_image_headline.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_image_headline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label_image_headline.Location = new System.Drawing.Point(8, 310);
            this.label_image_headline.Name = "label_image_headline";
            this.label_image_headline.Size = new System.Drawing.Size(400, 20);
            this.label_image_headline.TabIndex = 4;
            this.label_image_headline.Text = "正在获取...";
            this.label_image_headline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Download1080p
            // 
            this.button_Download1080p.Location = new System.Drawing.Point(11, 333);
            this.button_Download1080p.Name = "button_Download1080p";
            this.button_Download1080p.Size = new System.Drawing.Size(401, 42);
            this.button_Download1080p.TabIndex = 5;
            this.button_Download1080p.Text = "下载壁纸(1080P)";
            this.button_Download1080p.UseVisualStyleBackColor = true;
            this.button_Download1080p.Click += new System.EventHandler(this.button_Download1080p_Click);
            // 
            // button_Download4K
            // 
            this.button_Download4K.Location = new System.Drawing.Point(12, 381);
            this.button_Download4K.Name = "button_Download4K";
            this.button_Download4K.Size = new System.Drawing.Size(401, 42);
            this.button_Download4K.TabIndex = 6;
            this.button_Download4K.Text = "下载壁纸(4K)";
            this.button_Download4K.UseVisualStyleBackColor = true;
            this.button_Download4K.Click += new System.EventHandler(this.button_Download4K_Click);
            // 
            // label_Copyright
            // 
            this.label_Copyright.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label_Copyright.Location = new System.Drawing.Point(12, 426);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(400, 20);
            this.label_Copyright.TabIndex = 7;
            this.label_Copyright.Text = "Copyright: 正在获取...";
            this.label_Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(298, 9);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(115, 27);
            this.button_Refresh.TabIndex = 8;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // bingWallpaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 453);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.button_Download4K);
            this.Controls.Add(this.button_Download1080p);
            this.Controls.Add(this.label_image_headline);
            this.Controls.Add(this.label_image_title);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox_overview);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bingWallpaper";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "必应每日壁纸";
            this.Load += new System.EventHandler(this.bingWallpaper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_overview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_overview;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.Label label_image_title;
        private System.Windows.Forms.Label label_image_headline;
        private System.Windows.Forms.Button button_Download1080p;
        private System.Windows.Forms.Button button_Download4K;
        private System.Windows.Forms.Label label_Copyright;
        private System.Windows.Forms.Button button_Refresh;
    }
}