namespace ApiHub.apiForms._60sAPI
{
    partial class NcmListInfo
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Subtitle = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.linkLabel_GetID = new System.Windows.Forms.LinkLabel();
            this.label_RankName = new System.Windows.Forms.Label();
            this.listView_main = new System.Windows.Forms.ListView();
            this.columnHeader_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_published = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(237, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "[实时] 网易云榜单详细";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Subtitle
            // 
            this.label_Subtitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Subtitle.Location = new System.Drawing.Point(13, 47);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.Size = new System.Drawing.Size(237, 20);
            this.label_Subtitle.TabIndex = 1;
            this.label_Subtitle.Text = "网易云音乐榜单";
            this.label_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.Location = new System.Drawing.Point(659, 12);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(100, 30);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label_ID
            // 
            this.label_ID.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ID.Location = new System.Drawing.Point(12, 70);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(56, 23);
            this.label_ID.TabIndex = 4;
            this.label_ID.Text = "榜单ID:";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.Location = new System.Drawing.Point(659, 70);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(100, 23);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "搜索";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(74, 70);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(579, 23);
            this.textBox_ID.TabIndex = 6;
            // 
            // linkLabel_GetID
            // 
            this.linkLabel_GetID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_GetID.Location = new System.Drawing.Point(594, 50);
            this.linkLabel_GetID.Name = "linkLabel_GetID";
            this.linkLabel_GetID.Size = new System.Drawing.Size(165, 20);
            this.linkLabel_GetID.TabIndex = 7;
            this.linkLabel_GetID.TabStop = true;
            this.linkLabel_GetID.Text = "获取榜单ID";
            this.linkLabel_GetID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel_GetID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GetID_LinkClicked);
            // 
            // label_RankName
            // 
            this.label_RankName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_RankName.Location = new System.Drawing.Point(13, 96);
            this.label_RankName.Name = "label_RankName";
            this.label_RankName.Size = new System.Drawing.Size(237, 20);
            this.label_RankName.TabIndex = 8;
            this.label_RankName.Text = "榜单: 等待获取...";
            this.label_RankName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView_main
            // 
            this.listView_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_title,
            this.columnHeader_artist,
            this.columnHeader_album,
            this.columnHeader_published});
            this.listView_main.HideSelection = false;
            this.listView_main.Location = new System.Drawing.Point(12, 119);
            this.listView_main.Name = "listView_main";
            this.listView_main.Size = new System.Drawing.Size(747, 233);
            this.listView_main.TabIndex = 9;
            this.listView_main.UseCompatibleStateImageBehavior = false;
            this.listView_main.View = System.Windows.Forms.View.Details;
            this.listView_main.ItemActivate += new System.EventHandler(this.listView_main_ItemActivate);
            // 
            // columnHeader_title
            // 
            this.columnHeader_title.Text = "歌名";
            this.columnHeader_title.Width = 254;
            // 
            // columnHeader_artist
            // 
            this.columnHeader_artist.Text = "作者";
            this.columnHeader_artist.Width = 135;
            // 
            // columnHeader_album
            // 
            this.columnHeader_album.Text = "专辑";
            this.columnHeader_album.Width = 132;
            // 
            // columnHeader_published
            // 
            this.columnHeader_published.Text = "发布时间";
            this.columnHeader_published.Width = 198;
            // 
            // label_Tip
            // 
            this.label_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Tip.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Tip.Location = new System.Drawing.Point(522, 96);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(237, 20);
            this.label_Tip.TabIndex = 10;
            this.label_Tip.Text = "双击查看详细信息";
            this.label_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NcmListInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 364);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.listView_main);
            this.Controls.Add(this.label_RankName);
            this.Controls.Add(this.linkLabel_GetID);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(787, 403);
            this.Name = "NcmListInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网易云榜单详细";
            this.Resize += new System.EventHandler(this.NcmListInfo_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.LinkLabel linkLabel_GetID;
        private System.Windows.Forms.Label label_RankName;
        private System.Windows.Forms.ListView listView_main;
        private System.Windows.Forms.ColumnHeader columnHeader_title;
        private System.Windows.Forms.ColumnHeader columnHeader_artist;
        private System.Windows.Forms.ColumnHeader columnHeader_album;
        private System.Windows.Forms.ColumnHeader columnHeader_published;
        private System.Windows.Forms.Label label_Tip;
    }
}