namespace Quick60s
{
    partial class Settings
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
            this.label_api_url = new System.Windows.Forms.Label();
            this.comboBox_api_url = new System.Windows.Forms.ComboBox();
            this.button_SaveAndBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(164, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "设置";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_api_url
            // 
            this.label_api_url.Location = new System.Drawing.Point(14, 49);
            this.label_api_url.Name = "label_api_url";
            this.label_api_url.Size = new System.Drawing.Size(125, 20);
            this.label_api_url.TabIndex = 1;
            this.label_api_url.Text = "API地址(重启后生效):";
            this.label_api_url.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_api_url
            // 
            this.comboBox_api_url.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_api_url.FormattingEnabled = true;
            this.comboBox_api_url.Items.AddRange(new object[] {
            "main (主线路, 稳定但大陆无法访问)",
            "sub1 (备用1, 大陆无法访问)",
            "sub2 (备用2, 大陆无法访问)",
            "cn1 (推荐, 大陆可访问)",
            "cn2 (cn1无法使用时使用此线路, 大陆可访问)"});
            this.comboBox_api_url.Location = new System.Drawing.Point(145, 48);
            this.comboBox_api_url.Name = "comboBox_api_url";
            this.comboBox_api_url.Size = new System.Drawing.Size(352, 25);
            this.comboBox_api_url.TabIndex = 2;
            // 
            // button_SaveAndBack
            // 
            this.button_SaveAndBack.Location = new System.Drawing.Point(392, 236);
            this.button_SaveAndBack.Name = "button_SaveAndBack";
            this.button_SaveAndBack.Size = new System.Drawing.Size(105, 33);
            this.button_SaveAndBack.TabIndex = 3;
            this.button_SaveAndBack.Text = "保存并关闭";
            this.button_SaveAndBack.UseVisualStyleBackColor = true;
            this.button_SaveAndBack.Click += new System.EventHandler(this.button_SaveAndBack_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 281);
            this.Controls.Add(this.button_SaveAndBack);
            this.Controls.Add(this.comboBox_api_url);
            this.Controls.Add(this.label_api_url);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_api_url;
        private System.Windows.Forms.ComboBox comboBox_api_url;
        private System.Windows.Forms.Button button_SaveAndBack;
    }
}