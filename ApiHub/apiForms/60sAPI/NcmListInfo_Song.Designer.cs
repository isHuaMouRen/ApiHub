namespace ApiHub.apiForms._60sAPI
{
    partial class NcmListInfo_Song
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
            this.pictureBox_Cover = new System.Windows.Forms.PictureBox();
            this.linkLabel_Album = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Title = new System.Windows.Forms.LinkLabel();
            this.listView_Artist = new System.Windows.Forms.ListView();
            this.columnHeader_artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Size = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Cover
            // 
            this.pictureBox_Cover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Cover.Location = new System.Drawing.Point(238, 12);
            this.pictureBox_Cover.Name = "pictureBox_Cover";
            this.pictureBox_Cover.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Cover.TabIndex = 1;
            this.pictureBox_Cover.TabStop = false;
            // 
            // linkLabel_Album
            // 
            this.linkLabel_Album.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_Album.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_Album.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_Album.Location = new System.Drawing.Point(373, 52);
            this.linkLabel_Album.Name = "linkLabel_Album";
            this.linkLabel_Album.Size = new System.Drawing.Size(377, 20);
            this.linkLabel_Album.TabIndex = 3;
            this.linkLabel_Album.TabStop = true;
            this.linkLabel_Album.Text = "专辑: unknown";
            this.linkLabel_Album.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel_Album.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Album_LinkClicked);
            // 
            // linkLabel_Title
            // 
            this.linkLabel_Title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_Title.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_Title.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_Title.Location = new System.Drawing.Point(372, 12);
            this.linkLabel_Title.Name = "linkLabel_Title";
            this.linkLabel_Title.Size = new System.Drawing.Size(377, 40);
            this.linkLabel_Title.TabIndex = 4;
            this.linkLabel_Title.TabStop = true;
            this.linkLabel_Title.Text = "音乐名";
            this.linkLabel_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel_Title.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Title_LinkClicked);
            // 
            // listView_Artist
            // 
            this.listView_Artist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_artist});
            this.listView_Artist.HideSelection = false;
            this.listView_Artist.Location = new System.Drawing.Point(12, 12);
            this.listView_Artist.Name = "listView_Artist";
            this.listView_Artist.Size = new System.Drawing.Size(220, 128);
            this.listView_Artist.TabIndex = 5;
            this.listView_Artist.UseCompatibleStateImageBehavior = false;
            this.listView_Artist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_artist
            // 
            this.columnHeader_artist.Text = "歌手";
            this.columnHeader_artist.Width = 188;
            // 
            // label_Time
            // 
            this.label_Time.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Time.Location = new System.Drawing.Point(373, 72);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(376, 20);
            this.label_Time.TabIndex = 6;
            this.label_Time.Text = "时长: unknown";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Size
            // 
            this.label_Size.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Size.Location = new System.Drawing.Point(373, 92);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(376, 48);
            this.label_Size.TabIndex = 7;
            this.label_Size.Text = "大小: unknown";
            this.label_Size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NcmListInfo_Song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 150);
            this.Controls.Add(this.label_Size);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.listView_Artist);
            this.Controls.Add(this.linkLabel_Title);
            this.Controls.Add(this.linkLabel_Album);
            this.Controls.Add(this.pictureBox_Cover);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NcmListInfo_Song";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音乐详细";
            this.Load += new System.EventHandler(this.NcmListInfo_Song_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_Cover;
        private System.Windows.Forms.LinkLabel linkLabel_Album;
        private System.Windows.Forms.LinkLabel linkLabel_Title;
        private System.Windows.Forms.ListView listView_Artist;
        private System.Windows.Forms.ColumnHeader columnHeader_artist;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Size;
    }
}