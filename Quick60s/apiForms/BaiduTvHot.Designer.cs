namespace ApiHub.apiForms
{
    partial class BaiduTvHot
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "正在获取...",
            "正在获取...",
            "正在获取..."}, -1);
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Subtitle = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label_Tip = new System.Windows.Forms.Label();
            this.listView_main = new System.Windows.Forms.ListView();
            this.columnHeader_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(447, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "[实时] 百度电视剧榜";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Subtitle
            // 
            this.label_Subtitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Subtitle.Location = new System.Drawing.Point(13, 49);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.Size = new System.Drawing.Size(226, 20);
            this.label_Subtitle.TabIndex = 1;
            this.label_Subtitle.Text = "百度电视剧榜";
            this.label_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.Location = new System.Drawing.Point(582, 12);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(100, 30);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label_Tip
            // 
            this.label_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Tip.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Tip.Location = new System.Drawing.Point(427, 49);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(255, 20);
            this.label_Tip.TabIndex = 3;
            this.label_Tip.Text = "双击查看详细信息";
            this.label_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView_main
            // 
            this.listView_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_title,
            this.columnHeader_desc,
            this.columnHeader_score});
            this.listView_main.HideSelection = false;
            this.listView_main.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_main.Location = new System.Drawing.Point(12, 72);
            this.listView_main.Name = "listView_main";
            this.listView_main.Size = new System.Drawing.Size(670, 267);
            this.listView_main.TabIndex = 4;
            this.listView_main.UseCompatibleStateImageBehavior = false;
            this.listView_main.View = System.Windows.Forms.View.Details;
            this.listView_main.ItemActivate += new System.EventHandler(this.listView_main_ItemActivate);
            // 
            // columnHeader_title
            // 
            this.columnHeader_title.Text = "标题";
            this.columnHeader_title.Width = 167;
            // 
            // columnHeader_desc
            // 
            this.columnHeader_desc.Text = "详细";
            this.columnHeader_desc.Width = 367;
            // 
            // columnHeader_score
            // 
            this.columnHeader_score.Text = "热度";
            this.columnHeader_score.Width = 87;
            // 
            // BaiduTvHot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 351);
            this.Controls.Add(this.listView_main);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaiduTvHot";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度电视剧榜";
            this.Load += new System.EventHandler(this.BaiduTvHot_Load);
            this.Resize += new System.EventHandler(this.BaiduTvHot_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label_Tip;
        private System.Windows.Forms.ListView listView_main;
        private System.Windows.Forms.ColumnHeader columnHeader_title;
        private System.Windows.Forms.ColumnHeader columnHeader_desc;
        private System.Windows.Forms.ColumnHeader columnHeader_score;
    }
}