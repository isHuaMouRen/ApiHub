namespace ApiHub.apiForms._60sAPI
{
    partial class Fanyi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Target = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Source = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.textBox_To = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Translate = new System.Windows.Forms.Button();
            this.linkLabel_GetLanguageCode = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(378, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "[工具] 在线翻译";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Subtitle
            // 
            this.label_Subtitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Subtitle.Location = new System.Drawing.Point(13, 49);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.Size = new System.Drawing.Size(737, 20);
            this.label_Subtitle.TabIndex = 1;
            this.label_Subtitle.Text = "网易有道提供的109种语言的在线翻译                     源语言与目标语言需填写语言代码                填auto为自动识别";
            this.label_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.Location = new System.Drawing.Point(650, 12);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(100, 30);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "刷新";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_Target);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_Source);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 281);
            this.panel1.TabIndex = 3;
            // 
            // textBox_Target
            // 
            this.textBox_Target.BackColor = System.Drawing.Color.White;
            this.textBox_Target.Location = new System.Drawing.Point(356, 23);
            this.textBox_Target.MaxLength = 2147483647;
            this.textBox_Target.Multiline = true;
            this.textBox_Target.Name = "textBox_Target";
            this.textBox_Target.ReadOnly = true;
            this.textBox_Target.Size = new System.Drawing.Size(377, 253);
            this.textBox_Target.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(356, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "翻译内容:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Source
            // 
            this.textBox_Source.Location = new System.Drawing.Point(3, 23);
            this.textBox_Source.MaxLength = 2147483647;
            this.textBox_Source.Multiline = true;
            this.textBox_Source.Name = "textBox_Source";
            this.textBox_Source.Size = new System.Drawing.Size(347, 253);
            this.textBox_Source.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "源内容:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "源语言:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_From
            // 
            this.textBox_From.Location = new System.Drawing.Point(83, 81);
            this.textBox_From.Name = "textBox_From";
            this.textBox_From.Size = new System.Drawing.Size(228, 23);
            this.textBox_From.TabIndex = 5;
            this.textBox_From.Text = "auto";
            // 
            // textBox_To
            // 
            this.textBox_To.Location = new System.Drawing.Point(396, 81);
            this.textBox_To.Name = "textBox_To";
            this.textBox_To.Size = new System.Drawing.Size(228, 23);
            this.textBox_To.TabIndex = 7;
            this.textBox_To.Text = "auto";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(317, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "目标语言:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Translate
            // 
            this.button_Translate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Translate.Location = new System.Drawing.Point(630, 81);
            this.button_Translate.Name = "button_Translate";
            this.button_Translate.Size = new System.Drawing.Size(120, 23);
            this.button_Translate.TabIndex = 8;
            this.button_Translate.Text = "翻译";
            this.button_Translate.UseVisualStyleBackColor = true;
            this.button_Translate.Click += new System.EventHandler(this.button_Translate_Click);
            // 
            // linkLabel_GetLanguageCode
            // 
            this.linkLabel_GetLanguageCode.Location = new System.Drawing.Point(544, 22);
            this.linkLabel_GetLanguageCode.Name = "linkLabel_GetLanguageCode";
            this.linkLabel_GetLanguageCode.Size = new System.Drawing.Size(100, 20);
            this.linkLabel_GetLanguageCode.TabIndex = 9;
            this.linkLabel_GetLanguageCode.TabStop = true;
            this.linkLabel_GetLanguageCode.Text = "获取语言代码";
            this.linkLabel_GetLanguageCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel_GetLanguageCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GetLanguageCode_LinkClicked);
            // 
            // Fanyi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 407);
            this.Controls.Add(this.linkLabel_GetLanguageCode);
            this.Controls.Add(this.button_Translate);
            this.Controls.Add(this.textBox_To);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_From);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fanyi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在线翻译";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_From;
        private System.Windows.Forms.TextBox textBox_To;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Translate;
        private System.Windows.Forms.TextBox textBox_Target;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Source;
        private System.Windows.Forms.LinkLabel linkLabel_GetLanguageCode;
    }
}