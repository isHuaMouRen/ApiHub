namespace ApiHub.apiForms
{
    partial class ExchangeRate
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "正在获取...",
            "正在获取..."}, -1);
            this.label_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_main = new System.Windows.Forms.ListView();
            this.columnHeader_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabel_GoWebside = new System.Windows.Forms.LinkLabel();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(11, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(231, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "[日更] 当日货币汇率";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "实时货币汇率\t";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView_main
            // 
            this.listView_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_code,
            this.columnHeader_rate});
            this.listView_main.HideSelection = false;
            this.listView_main.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView_main.Location = new System.Drawing.Point(16, 72);
            this.listView_main.Name = "listView_main";
            this.listView_main.Size = new System.Drawing.Size(458, 231);
            this.listView_main.TabIndex = 2;
            this.listView_main.UseCompatibleStateImageBehavior = false;
            this.listView_main.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_code
            // 
            this.columnHeader_code.Text = "货币代号";
            this.columnHeader_code.Width = 121;
            // 
            // columnHeader_rate
            // 
            this.columnHeader_rate.Text = "汇率";
            this.columnHeader_rate.Width = 271;
            // 
            // linkLabel_GoWebside
            // 
            this.linkLabel_GoWebside.Location = new System.Drawing.Point(386, 49);
            this.linkLabel_GoWebside.Name = "linkLabel_GoWebside";
            this.linkLabel_GoWebside.Size = new System.Drawing.Size(88, 20);
            this.linkLabel_GoWebside.TabIndex = 3;
            this.linkLabel_GoWebside.TabStop = true;
            this.linkLabel_GoWebside.Text = "查询货币代码";
            this.linkLabel_GoWebside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel_GoWebside.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GoWebside_LinkClicked);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(16, 309);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(377, 23);
            this.textBox_Search.TabIndex = 4;
            this.textBox_Search.Text = "正在获取...";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(399, 309);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "搜索";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(360, 9);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(114, 27);
            this.button_Refresh.TabIndex = 6;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // ExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 346);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.linkLabel_GoWebside);
            this.Controls.Add(this.listView_main);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(502, 385);
            this.Name = "ExchangeRate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "货币汇率";
            this.Load += new System.EventHandler(this.ExchangeRate_Load);
            this.Resize += new System.EventHandler(this.ExchangeRate_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_main;
        private System.Windows.Forms.ColumnHeader columnHeader_code;
        private System.Windows.Forms.ColumnHeader columnHeader_rate;
        private System.Windows.Forms.LinkLabel linkLabel_GoWebside;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Refresh;
    }
}