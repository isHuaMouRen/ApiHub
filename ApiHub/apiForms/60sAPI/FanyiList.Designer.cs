namespace ApiHub.apiForms._60sAPI
{
    partial class FanyiList
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
            this.button_Refresh = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_alphaBet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(12, 12);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(344, 30);
            this.button_Refresh.TabIndex = 0;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_name,
            this.columnHeader_code,
            this.columnHeader_alphaBet});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 270);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "语言";
            this.columnHeader_name.Width = 143;
            // 
            // columnHeader_code
            // 
            this.columnHeader_code.Text = "代码";
            this.columnHeader_code.Width = 75;
            // 
            // columnHeader_alphaBet
            // 
            this.columnHeader_alphaBet.Text = "字母序列号";
            this.columnHeader_alphaBet.Width = 82;
            // 
            // FanyiList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 330);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_Refresh);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FanyiList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "语言代码列表";
            this.Load += new System.EventHandler(this.FanyiList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_code;
        private System.Windows.Forms.ColumnHeader columnHeader_alphaBet;
    }
}