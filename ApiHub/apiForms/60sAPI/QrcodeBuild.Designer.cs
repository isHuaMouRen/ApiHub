namespace ApiHub.apiForms._60sAPI
{
    partial class QrcodeBuild
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Text = new System.Windows.Forms.TextBox();
            this.numericUpDown_Size = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_Qrcode = new System.Windows.Forms.PictureBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Build = new System.Windows.Forms.Button();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(359, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "[工具] 生成二维码";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Subtitle
            // 
            this.label_Subtitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Subtitle.Location = new System.Drawing.Point(13, 49);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.Size = new System.Drawing.Size(359, 20);
            this.label_Subtitle.TabIndex = 1;
            this.label_Subtitle.Text = "支持生成 URL/文本 内容的二维码";
            this.label_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.Location = new System.Drawing.Point(445, 12);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(100, 30);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "二维码内容:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.button_Build);
            this.panel_main.Controls.Add(this.button_Save);
            this.panel_main.Controls.Add(this.pictureBox_Qrcode);
            this.panel_main.Controls.Add(this.numericUpDown_Size);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.textBox_Text);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Location = new System.Drawing.Point(12, 72);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(535, 190);
            this.panel_main.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "分辨率(单位: 像素) (默认: 256):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Text
            // 
            this.textBox_Text.Location = new System.Drawing.Point(98, 3);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.Size = new System.Drawing.Size(432, 23);
            this.textBox_Text.TabIndex = 4;
            this.textBox_Text.Text = "Hello world";
            // 
            // numericUpDown_Size
            // 
            this.numericUpDown_Size.Location = new System.Drawing.Point(214, 33);
            this.numericUpDown_Size.Maximum = new decimal(new int[] {
            -1614348222,
            266,
            0,
            0});
            this.numericUpDown_Size.Name = "numericUpDown_Size";
            this.numericUpDown_Size.Size = new System.Drawing.Size(316, 23);
            this.numericUpDown_Size.TabIndex = 6;
            this.numericUpDown_Size.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // pictureBox_Qrcode
            // 
            this.pictureBox_Qrcode.Location = new System.Drawing.Point(3, 55);
            this.pictureBox_Qrcode.Name = "pictureBox_Qrcode";
            this.pictureBox_Qrcode.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_Qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Qrcode.TabIndex = 7;
            this.pictureBox_Qrcode.TabStop = false;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(137, 137);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(393, 46);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "下载";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Build
            // 
            this.button_Build.Location = new System.Drawing.Point(137, 62);
            this.button_Build.Name = "button_Build";
            this.button_Build.Size = new System.Drawing.Size(393, 69);
            this.button_Build.TabIndex = 9;
            this.button_Build.Text = "生成";
            this.button_Build.UseVisualStyleBackColor = true;
            this.button_Build.Click += new System.EventHandler(this.button_Build_Click);
            // 
            // QrcodeBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 273);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QrcodeBuild";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成二维码";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Qrcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TextBox textBox_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Size;
        private System.Windows.Forms.PictureBox pictureBox_Qrcode;
        private System.Windows.Forms.Button button_Build;
        private System.Windows.Forms.Button button_Save;
    }
}