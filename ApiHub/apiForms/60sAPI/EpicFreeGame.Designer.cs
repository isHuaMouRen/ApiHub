namespace ApiHub.apiForms._60sAPI
{
    partial class EpicFreeGame
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
            this.label_Tip = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_originPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_isFree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_freeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_freeEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(391, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "[工具] Epic Games 免费游戏";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Subtitle
            // 
            this.label_Subtitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Subtitle.Location = new System.Drawing.Point(13, 49);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.Size = new System.Drawing.Size(391, 20);
            this.label_Subtitle.TabIndex = 1;
            this.label_Subtitle.Text = "每周更新的Epic Games 免费游戏";
            this.label_Subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.Location = new System.Drawing.Point(673, 12);
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
            this.label_Tip.Location = new System.Drawing.Point(490, 49);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(283, 20);
            this.label_Tip.TabIndex = 3;
            this.label_Tip.Text = "双击查看详细信息";
            this.label_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_title,
            this.columnHeader_description,
            this.columnHeader_originPrice,
            this.columnHeader_isFree,
            this.columnHeader_freeStart,
            this.columnHeader_freeEnd});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(761, 260);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // columnHeader_title
            // 
            this.columnHeader_title.Text = "游戏";
            // 
            // columnHeader_originPrice
            // 
            this.columnHeader_originPrice.Text = "原价";
            // 
            // columnHeader_description
            // 
            this.columnHeader_description.Text = "游戏描述";
            // 
            // columnHeader_isFree
            // 
            this.columnHeader_isFree.Text = "是否免费";
            // 
            // columnHeader_freeStart
            // 
            this.columnHeader_freeStart.Text = "开始免费";
            // 
            // columnHeader_freeEnd
            // 
            this.columnHeader_freeEnd.Text = "结束免费";
            // 
            // EpicFreeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 344);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EpicFreeGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Epic Games 免费游戏";
            this.Load += new System.EventHandler(this.EpicFreeGame_Load);
            this.Resize += new System.EventHandler(this.EpicFreeGame_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label_Tip;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_title;
        private System.Windows.Forms.ColumnHeader columnHeader_description;
        private System.Windows.Forms.ColumnHeader columnHeader_originPrice;
        private System.Windows.Forms.ColumnHeader columnHeader_isFree;
        private System.Windows.Forms.ColumnHeader columnHeader_freeStart;
        private System.Windows.Forms.ColumnHeader columnHeader_freeEnd;
    }
}