namespace ApiHub.apiForms._60sAPI
{
    partial class Weather
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Refreh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Weather = new System.Windows.Forms.Label();
            this.pictureBox_WeatherIcon = new System.Windows.Forms.PictureBox();
            this.label_UpdateDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_tips = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "[工具] 实时天气";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "由腾讯天气提供的实时天气，可智能搜索城市";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Refreh
            // 
            this.button_Refreh.Location = new System.Drawing.Point(658, 12);
            this.button_Refreh.Name = "button_Refreh";
            this.button_Refreh.Size = new System.Drawing.Size(100, 30);
            this.button_Refreh.TabIndex = 2;
            this.button_Refreh.Text = "刷新";
            this.button_Refreh.UseVisualStyleBackColor = true;
            this.button_Refreh.Click += new System.EventHandler(this.button_Refreh_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "地区:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(73, 72);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(584, 23);
            this.textBox_Search.TabIndex = 4;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(663, 72);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(95, 23);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "搜索";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_tips);
            this.panel1.Controls.Add(this.label_UpdateDate);
            this.panel1.Controls.Add(this.pictureBox_WeatherIcon);
            this.panel1.Controls.Add(this.label_Weather);
            this.panel1.Controls.Add(this.label_Title);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 237);
            this.panel1.TabIndex = 6;
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(87, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(325, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "等待获取";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Weather
            // 
            this.label_Weather.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Weather.Location = new System.Drawing.Point(87, 60);
            this.label_Weather.Name = "label_Weather";
            this.label_Weather.Size = new System.Drawing.Size(654, 43);
            this.label_Weather.TabIndex = 2;
            this.label_Weather.Text = "天气: {data}  温度: {data}  湿度: {data}  风向: {data}  风力: {data}  空气质量: {data}  日出: {da" +
    "ta}  日落: {data}";
            this.label_Weather.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_WeatherIcon
            // 
            this.pictureBox_WeatherIcon.Location = new System.Drawing.Point(4, 3);
            this.pictureBox_WeatherIcon.Name = "pictureBox_WeatherIcon";
            this.pictureBox_WeatherIcon.Size = new System.Drawing.Size(77, 77);
            this.pictureBox_WeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_WeatherIcon.TabIndex = 3;
            this.pictureBox_WeatherIcon.TabStop = false;
            // 
            // label_UpdateDate
            // 
            this.label_UpdateDate.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_UpdateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label_UpdateDate.Location = new System.Drawing.Point(87, 40);
            this.label_UpdateDate.Name = "label_UpdateDate";
            this.label_UpdateDate.Size = new System.Drawing.Size(306, 20);
            this.label_UpdateDate.TabIndex = 4;
            this.label_UpdateDate.Text = "更新时间: {data}";
            this.label_UpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "生活建议:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_tips
            // 
            this.textBox_tips.BackColor = System.Drawing.Color.White;
            this.textBox_tips.Location = new System.Drawing.Point(3, 106);
            this.textBox_tips.MaxLength = 2147483647;
            this.textBox_tips.Multiline = true;
            this.textBox_tips.Name = "textBox_tips";
            this.textBox_tips.ReadOnly = true;
            this.textBox_tips.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_tips.Size = new System.Drawing.Size(738, 126);
            this.textBox_tips.TabIndex = 6;
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Refreh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Weather";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实时天气";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Refreh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Weather;
        private System.Windows.Forms.PictureBox pictureBox_WeatherIcon;
        private System.Windows.Forms.Label label_UpdateDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_tips;
    }
}