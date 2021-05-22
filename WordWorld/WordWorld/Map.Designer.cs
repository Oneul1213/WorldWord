namespace WordWorld
{
    partial class Map
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
            this.panelMapInfo = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonEnterMap = new System.Windows.Forms.Button();
            this.panelMapInfoText = new System.Windows.Forms.Panel();
            this.labelMobInfo = new System.Windows.Forms.Label();
            this.labelMapName = new System.Windows.Forms.Label();
            this.pictureBoxMapPhoto = new System.Windows.Forms.PictureBox();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panelPlace텃밭 = new System.Windows.Forms.Panel();
            this.panelPlace과수원 = new System.Windows.Forms.Panel();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.labelSpliter = new System.Windows.Forms.Label();
            this.panelMapInfo.SuspendLayout();
            this.panelMapInfoText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapPhoto)).BeginInit();
            this.panelMap.SuspendLayout();
            this.panelPlace과수원.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMapInfo
            // 
            this.panelMapInfo.BackColor = System.Drawing.SystemColors.Window;
            this.panelMapInfo.Controls.Add(this.buttonHome);
            this.panelMapInfo.Controls.Add(this.buttonEnterMap);
            this.panelMapInfo.Controls.Add(this.panelMapInfoText);
            this.panelMapInfo.Controls.Add(this.pictureBoxMapPhoto);
            this.panelMapInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMapInfo.Location = new System.Drawing.Point(0, 295);
            this.panelMapInfo.Name = "panelMapInfo";
            this.panelMapInfo.Size = new System.Drawing.Size(802, 158);
            this.panelMapInfo.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonHome.Location = new System.Drawing.Point(619, 90);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(162, 55);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "홈";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // buttonEnterMap
            // 
            this.buttonEnterMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterMap.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonEnterMap.Location = new System.Drawing.Point(619, 19);
            this.buttonEnterMap.Name = "buttonEnterMap";
            this.buttonEnterMap.Size = new System.Drawing.Size(162, 55);
            this.buttonEnterMap.TabIndex = 2;
            this.buttonEnterMap.Text = "입장";
            this.buttonEnterMap.UseVisualStyleBackColor = true;
            this.buttonEnterMap.Click += new System.EventHandler(this.ButtonEnterMap_Click);
            // 
            // panelMapInfoText
            // 
            this.panelMapInfoText.Controls.Add(this.labelMobInfo);
            this.panelMapInfoText.Controls.Add(this.labelMapName);
            this.panelMapInfoText.Location = new System.Drawing.Point(239, 17);
            this.panelMapInfoText.Name = "panelMapInfoText";
            this.panelMapInfoText.Size = new System.Drawing.Size(362, 128);
            this.panelMapInfoText.TabIndex = 1;
            // 
            // labelMobInfo
            // 
            this.labelMobInfo.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMobInfo.Location = new System.Drawing.Point(3, 46);
            this.labelMobInfo.Name = "labelMobInfo";
            this.labelMobInfo.Size = new System.Drawing.Size(223, 40);
            this.labelMobInfo.TabIndex = 1;
            this.labelMobInfo.Text = "출현 적 목록";
            this.labelMobInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMapName
            // 
            this.labelMapName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMapName.Location = new System.Drawing.Point(3, 9);
            this.labelMapName.Name = "labelMapName";
            this.labelMapName.Size = new System.Drawing.Size(133, 37);
            this.labelMapName.TabIndex = 0;
            this.labelMapName.Text = "장소 이름";
            this.labelMapName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxMapPhoto
            // 
            this.pictureBoxMapPhoto.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxMapPhoto.Name = "pictureBoxMapPhoto";
            this.pictureBoxMapPhoto.Size = new System.Drawing.Size(205, 130);
            this.pictureBoxMapPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMapPhoto.TabIndex = 0;
            this.pictureBoxMapPhoto.TabStop = false;
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.SystemColors.Window;
            this.panelMap.Controls.Add(this.panelPlace텃밭);
            this.panelMap.Controls.Add(this.panelPlace과수원);
            this.panelMap.Controls.Add(this.labelSpliter);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(802, 295);
            this.panelMap.TabIndex = 1;
            // 
            // panelPlace텃밭
            // 
            this.panelPlace텃밭.BackColor = System.Drawing.Color.Transparent;
            this.panelPlace텃밭.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPlace텃밭.Location = new System.Drawing.Point(193, 53);
            this.panelPlace텃밭.Name = "panelPlace텃밭";
            this.panelPlace텃밭.Size = new System.Drawing.Size(95, 95);
            this.panelPlace텃밭.TabIndex = 6;
            this.panelPlace텃밭.Click += new System.EventHandler(this.PanelPlace_Click);
            // 
            // panelPlace과수원
            // 
            this.panelPlace과수원.BackColor = System.Drawing.Color.Transparent;
            this.panelPlace과수원.Controls.Add(this.pictureBoxPlayer);
            this.panelPlace과수원.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPlace과수원.Location = new System.Drawing.Point(46, 104);
            this.panelPlace과수원.Name = "panelPlace과수원";
            this.panelPlace과수원.Size = new System.Drawing.Size(95, 95);
            this.panelPlace과수원.TabIndex = 4;
            this.panelPlace과수원.Click += new System.EventHandler(this.PanelPlace_Click);
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(28, 13);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(30, 60);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer.TabIndex = 5;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // labelSpliter
            // 
            this.labelSpliter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSpliter.Location = new System.Drawing.Point(0, 287);
            this.labelSpliter.Name = "labelSpliter";
            this.labelSpliter.Size = new System.Drawing.Size(800, 2);
            this.labelSpliter.TabIndex = 3;
            this.labelSpliter.Text = "label1";
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.panelMapInfo);
            this.Name = "Map";
            this.Text = "WordWorld - Map";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Map_FormClosed);
            this.panelMapInfo.ResumeLayout(false);
            this.panelMapInfoText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapPhoto)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.panelPlace과수원.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMapInfo;
        private System.Windows.Forms.PictureBox pictureBoxMapPhoto;
        private System.Windows.Forms.Button buttonEnterMap;
        private System.Windows.Forms.Panel panelMapInfoText;
        private System.Windows.Forms.Label labelMobInfo;
        private System.Windows.Forms.Label labelMapName;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelSpliter;
        private System.Windows.Forms.Panel panelPlace과수원;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Panel panelPlace텃밭;
    }
}