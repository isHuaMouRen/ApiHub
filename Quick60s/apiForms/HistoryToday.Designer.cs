namespace Quick60s.apiForms
{
    partial class HistoryToday
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
            "正在获取...",
            "正在获取..."}, -1);
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Subtitle = new System.Windows.Forms.Label();
            this.listView_main = new System.Windows.Forms.ListView();
            this.label_Date = new System.Windows.Forms.Label();
            this.columnHeader_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(13, 9);
            this.label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(282, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "[日更] 历史上的今天";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Subtitle
            // 
            this.label_Subtitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Subtitle.Location = new System.Drawing.Point(13, 49);
            this.label_Subtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.Size = new System.Drawing.Size(282, 20);
            this.label_Subtitle.TabIndex = 1;
            this.label_Subtitle.Text = "历史上的今天";
            this.label_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView_main
            // 
            this.listView_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_title,
            this.columnHeader_year,
            this.columnHeader_description,
            this.columnHeader_type});
            this.listView_main.HideSelection = false;
            this.listView_main.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_main.Location = new System.Drawing.Point(18, 72);
            this.listView_main.Name = "listView_main";
            this.listView_main.Size = new System.Drawing.Size(868, 297);
            this.listView_main.TabIndex = 2;
            this.listView_main.UseCompatibleStateImageBehavior = false;
            this.listView_main.View = System.Windows.Forms.View.Details;
            this.listView_main.ItemActivate += new System.EventHandler(this.listView_main_ItemActivate);
            // 
            // label_Date
            // 
            this.label_Date.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Date.Location = new System.Drawing.Point(604, 49);
            this.label_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(282, 20);
            this.label_Date.TabIndex = 3;
            this.label_Date.Text = "日期: 正在获取...";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnHeader_title
            // 
            this.columnHeader_title.Text = "事件";
            this.columnHeader_title.Width = 167;
            // 
            // columnHeader_year
            // 
            this.columnHeader_year.Text = "年份";
            this.columnHeader_year.Width = 69;
            // 
            // columnHeader_description
            // 
            this.columnHeader_description.Text = "描述";
            this.columnHeader_description.Width = 497;
            // 
            // columnHeader_type
            // 
            this.columnHeader_type.Text = "事件类型";
            this.columnHeader_type.Width = 94;
            // 
            // label_tip
            // 
            this.label_tip.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tip.Location = new System.Drawing.Point(14, 372);
            this.label_tip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(282, 20);
            this.label_tip.TabIndex = 4;
            this.label_tip.Text = "(双击可打开详细信息)";
            this.label_tip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HistoryToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 404);
            this.Controls.Add(this.label_tip);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.listView_main);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoryToday";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "历史上的今天";
            this.Load += new System.EventHandler(this.HistoryToday_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.ListView listView_main;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.ColumnHeader columnHeader_title;
        private System.Windows.Forms.ColumnHeader columnHeader_year;
        private System.Windows.Forms.ColumnHeader columnHeader_description;
        private System.Windows.Forms.ColumnHeader columnHeader_type;
        private System.Windows.Forms.Label label_tip;
    }
}