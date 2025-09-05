namespace ApiHub.apiForms
{
    partial class _60sReadWorld
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
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label_tip = new System.Windows.Forms.Label();
            this.label_update = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(249, 30);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "[日更] 每天60秒读懂世界";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Subtitle
            // 
            this.label_Subtitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Subtitle.Location = new System.Drawing.Point(12, 39);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.Size = new System.Drawing.Size(555, 20);
            this.label_Subtitle.TabIndex = 1;
            this.label_Subtitle.Text = "每日精选新闻摘要";
            this.label_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Content
            // 
            this.textBox_Content.BackColor = System.Drawing.Color.White;
            this.textBox_Content.Location = new System.Drawing.Point(12, 86);
            this.textBox_Content.Multiline = true;
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.ReadOnly = true;
            this.textBox_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Content.Size = new System.Drawing.Size(555, 272);
            this.textBox_Content.TabIndex = 2;
            this.textBox_Content.Text = "正在获取中...";
            // 
            // label_Date
            // 
            this.label_Date.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Date.Location = new System.Drawing.Point(12, 59);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(555, 20);
            this.label_Date.TabIndex = 3;
            this.label_Date.Text = "日期: 正在获取中...";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(460, 9);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(107, 27);
            this.button_Refresh.TabIndex = 4;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label_tip
            // 
            this.label_tip.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tip.Location = new System.Drawing.Point(12, 361);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(555, 20);
            this.label_tip.TabIndex = 5;
            this.label_tip.Text = "——{ 正在获取... }——";
            this.label_tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_update
            // 
            this.label_update.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_update.Location = new System.Drawing.Point(12, 391);
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(555, 20);
            this.label_update.TabIndex = 6;
            this.label_update.Text = "更新时间: 正在获取...   API更新时间: 正在获取...";
            this.label_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _60sReadWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 422);
            this.Controls.Add(this.label_update);
            this.Controls.Add(this.label_tip);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.textBox_Content);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(595, 461);
            this.Name = "_60sReadWorld";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "60秒读懂世界";
            this.Load += new System.EventHandler(this._60sReadWorld_Load);
            this.Resize += new System.EventHandler(this._60sReadWorld_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.Label label_update;
    }
}