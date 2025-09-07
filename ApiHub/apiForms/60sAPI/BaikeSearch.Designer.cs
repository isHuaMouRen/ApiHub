namespace ApiHub.apiForms._60sAPI
{
    partial class BaikeSearch
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
            this.label_Subtitle = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_Abstract = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Titlee = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Subtitle
            // 
            this.label_Subtitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Subtitle.Location = new System.Drawing.Point(13, 49);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.Size = new System.Drawing.Size(265, 20);
            this.label_Subtitle.TabIndex = 1;
            this.label_Subtitle.Text = "智能搜索百度百科词条";
            this.label_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.Location = new System.Drawing.Point(646, 12);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(100, 30);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.label_Abstract);
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Controls.Add(this.label_Description);
            this.panel_main.Controls.Add(this.label_Titlee);
            this.panel_main.Location = new System.Drawing.Point(12, 108);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(734, 229);
            this.panel_main.TabIndex = 4;
            // 
            // label_Abstract
            // 
            this.label_Abstract.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Abstract.ForeColor = System.Drawing.Color.Black;
            this.label_Abstract.Location = new System.Drawing.Point(4, 69);
            this.label_Abstract.Name = "label_Abstract";
            this.label_Abstract.Size = new System.Drawing.Size(725, 158);
            this.label_Abstract.TabIndex = 4;
            this.label_Abstract.Text = "等待获取...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(553, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_Description
            // 
            this.label_Description.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label_Description.Location = new System.Drawing.Point(3, 40);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(544, 20);
            this.label_Description.TabIndex = 2;
            this.label_Description.Text = "等待获取...";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Titlee
            // 
            this.label_Titlee.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Titlee.Location = new System.Drawing.Point(3, 0);
            this.label_Titlee.Name = "label_Titlee";
            this.label_Titlee.Size = new System.Drawing.Size(544, 40);
            this.label_Titlee.TabIndex = 1;
            this.label_Titlee.Text = "等待获取...";
            this.label_Titlee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.Location = new System.Drawing.Point(651, 79);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(95, 23);
            this.button_Search.TabIndex = 8;
            this.button_Search.Text = "搜索";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(63, 79);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(582, 23);
            this.textBox_Search.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "搜索:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(265, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "[工具] 百度百科搜索";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaikeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 349);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaikeSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度百科搜索";
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Titlee;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Abstract;
    }
}