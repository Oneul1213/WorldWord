namespace WordWorld
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBoxPlayerPhoto = new System.Windows.Forms.PictureBox();
            this.panelPlayerInformation = new System.Windows.Forms.Panel();
            this.labelExpPercent = new System.Windows.Forms.Label();
            this.labelExpPercentNumber = new System.Windows.Forms.Label();
            this.progressBarExp = new System.Windows.Forms.ProgressBar();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelSpliter = new System.Windows.Forms.Label();
            this.labelLevelNumber = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.listBoxQuests = new System.Windows.Forms.ListBox();
            this.labelQuest = new System.Windows.Forms.Label();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.imageListPlayers = new System.Windows.Forms.ImageList(this.components);
            this.imageListPlayerPhotos = new System.Windows.Forms.ImageList(this.components);
            this.buttonMap = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExitGame = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxToggleMenu = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerPhoto)).BeginInit();
            this.panelPlayerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPlayerPhoto
            // 
            this.pictureBoxPlayerPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlayerPhoto.Location = new System.Drawing.Point(12, 276);
            this.pictureBoxPlayerPhoto.Name = "pictureBoxPlayerPhoto";
            this.pictureBoxPlayerPhoto.Size = new System.Drawing.Size(165, 165);
            this.pictureBoxPlayerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayerPhoto.TabIndex = 0;
            this.pictureBoxPlayerPhoto.TabStop = false;
            // 
            // panelPlayerInformation
            // 
            this.panelPlayerInformation.Controls.Add(this.labelExpPercent);
            this.panelPlayerInformation.Controls.Add(this.labelExpPercentNumber);
            this.panelPlayerInformation.Controls.Add(this.progressBarExp);
            this.panelPlayerInformation.Controls.Add(this.labelPlayerName);
            this.panelPlayerInformation.Controls.Add(this.labelExp);
            this.panelPlayerInformation.Controls.Add(this.labelSpliter);
            this.panelPlayerInformation.Controls.Add(this.labelLevelNumber);
            this.panelPlayerInformation.Controls.Add(this.labelLevel);
            this.panelPlayerInformation.Controls.Add(this.labelPlayer);
            this.panelPlayerInformation.Location = new System.Drawing.Point(196, 276);
            this.panelPlayerInformation.Name = "panelPlayerInformation";
            this.panelPlayerInformation.Size = new System.Drawing.Size(397, 164);
            this.panelPlayerInformation.TabIndex = 1;
            // 
            // labelExpPercent
            // 
            this.labelExpPercent.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelExpPercent.Location = new System.Drawing.Point(186, 138);
            this.labelExpPercent.Name = "labelExpPercent";
            this.labelExpPercent.Size = new System.Drawing.Size(41, 20);
            this.labelExpPercent.TabIndex = 8;
            this.labelExpPercent.Text = "%";
            // 
            // labelExpPercentNumber
            // 
            this.labelExpPercentNumber.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelExpPercentNumber.Location = new System.Drawing.Point(139, 138);
            this.labelExpPercentNumber.Name = "labelExpPercentNumber";
            this.labelExpPercentNumber.Size = new System.Drawing.Size(41, 20);
            this.labelExpPercentNumber.TabIndex = 7;
            this.labelExpPercentNumber.Text = "0";
            // 
            // progressBarExp
            // 
            this.progressBarExp.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarExp.Location = new System.Drawing.Point(139, 112);
            this.progressBarExp.Name = "progressBarExp";
            this.progressBarExp.Size = new System.Drawing.Size(243, 23);
            this.progressBarExp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarExp.TabIndex = 6;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPlayerName.Location = new System.Drawing.Point(134, 12);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(260, 38);
            this.labelPlayerName.TabIndex = 5;
            this.labelPlayerName.Text = "Player1";
            // 
            // labelExp
            // 
            this.labelExp.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelExp.Location = new System.Drawing.Point(13, 112);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(115, 38);
            this.labelExp.TabIndex = 4;
            this.labelExp.Text = "경험치";
            // 
            // labelSpliter
            // 
            this.labelSpliter.BackColor = System.Drawing.Color.Black;
            this.labelSpliter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSpliter.Location = new System.Drawing.Point(131, 0);
            this.labelSpliter.Name = "labelSpliter";
            this.labelSpliter.Size = new System.Drawing.Size(2, 164);
            this.labelSpliter.TabIndex = 3;
            // 
            // labelLevelNumber
            // 
            this.labelLevelNumber.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelLevelNumber.Location = new System.Drawing.Point(134, 63);
            this.labelLevelNumber.Name = "labelLevelNumber";
            this.labelLevelNumber.Size = new System.Drawing.Size(93, 38);
            this.labelLevelNumber.TabIndex = 2;
            this.labelLevelNumber.Text = "1";
            // 
            // labelLevel
            // 
            this.labelLevel.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelLevel.Location = new System.Drawing.Point(13, 63);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(115, 38);
            this.labelLevel.TabIndex = 1;
            this.labelLevel.Text = "경험도";
            // 
            // labelPlayer
            // 
            this.labelPlayer.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPlayer.Location = new System.Drawing.Point(13, 12);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(115, 38);
            this.labelPlayer.TabIndex = 0;
            this.labelPlayer.Text = "이름";
            // 
            // listBoxQuests
            // 
            this.listBoxQuests.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxQuests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxQuests.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxQuests.FormattingEnabled = true;
            this.listBoxQuests.ItemHeight = 20;
            this.listBoxQuests.Items.AddRange(new object[] {
            "의뢰 없음"});
            this.listBoxQuests.Location = new System.Drawing.Point(12, 51);
            this.listBoxQuests.Name = "listBoxQuests";
            this.listBoxQuests.Size = new System.Drawing.Size(165, 204);
            this.listBoxQuests.TabIndex = 2;
            // 
            // labelQuest
            // 
            this.labelQuest.BackColor = System.Drawing.SystemColors.Control;
            this.labelQuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelQuest.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelQuest.Location = new System.Drawing.Point(12, 13);
            this.labelQuest.Name = "labelQuest";
            this.labelQuest.Size = new System.Drawing.Size(165, 35);
            this.labelQuest.TabIndex = 3;
            this.labelQuest.Text = "의뢰";
            this.labelQuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuest.Click += new System.EventHandler(this.LabelQuest_Click);
            this.labelQuest.MouseEnter += new System.EventHandler(this.LabelQuest_MouseEnter);
            this.labelQuest.MouseLeave += new System.EventHandler(this.LabelQuest_MouseLeave);
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(327, 12);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(200, 240);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer.TabIndex = 4;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // imageListPlayers
            // 
            this.imageListPlayers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPlayers.ImageStream")));
            this.imageListPlayers.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPlayers.Images.SetKeyName(0, "man1.png");
            // 
            // imageListPlayerPhotos
            // 
            this.imageListPlayerPhotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPlayerPhotos.ImageStream")));
            this.imageListPlayerPhotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPlayerPhotos.Images.SetKeyName(0, "man1_photo.png");
            // 
            // buttonMap
            // 
            this.buttonMap.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMap.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonMap.Location = new System.Drawing.Point(625, 12);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(165, 35);
            this.buttonMap.TabIndex = 5;
            this.buttonMap.Text = "지도";
            this.buttonMap.UseVisualStyleBackColor = false;
            this.buttonMap.Click += new System.EventHandler(this.ButtonMap_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.buttonExitGame);
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Location = new System.Drawing.Point(619, 276);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 130);
            this.panelMenu.TabIndex = 7;
            this.panelMenu.Visible = false;
            // 
            // buttonExitGame
            // 
            this.buttonExitGame.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitGame.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonExitGame.Location = new System.Drawing.Point(-1, 35);
            this.buttonExitGame.Name = "buttonExitGame";
            this.buttonExitGame.Size = new System.Drawing.Size(165, 35);
            this.buttonExitGame.TabIndex = 1;
            this.buttonExitGame.Text = "게임 종료";
            this.buttonExitGame.UseVisualStyleBackColor = false;
            this.buttonExitGame.Click += new System.EventHandler(this.ButtonExitGame_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonLogout.Location = new System.Drawing.Point(-1, -1);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(165, 35);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "로그아웃";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // checkBoxToggleMenu
            // 
            this.checkBoxToggleMenu.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxToggleMenu.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxToggleMenu.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBoxToggleMenu.Location = new System.Drawing.Point(619, 406);
            this.checkBoxToggleMenu.Name = "checkBoxToggleMenu";
            this.checkBoxToggleMenu.Size = new System.Drawing.Size(165, 35);
            this.checkBoxToggleMenu.TabIndex = 8;
            this.checkBoxToggleMenu.Text = "메뉴";
            this.checkBoxToggleMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxToggleMenu.UseVisualStyleBackColor = false;
            this.checkBoxToggleMenu.Click += new System.EventHandler(this.CheckBoxToggleMenu_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.checkBoxToggleMenu);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.buttonMap);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.labelQuest);
            this.Controls.Add(this.listBoxQuests);
            this.Controls.Add(this.panelPlayerInformation);
            this.Controls.Add(this.pictureBoxPlayerPhoto);
            this.Name = "Main";
            this.Text = "WordWorld - Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerPhoto)).EndInit();
            this.panelPlayerInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayerPhoto;
        private System.Windows.Forms.Panel panelPlayerInformation;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelSpliter;
        private System.Windows.Forms.Label labelLevelNumber;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.ProgressBar progressBarExp;
        private System.Windows.Forms.ListBox listBoxQuests;
        private System.Windows.Forms.Label labelQuest;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.ImageList imageListPlayers;
        private System.Windows.Forms.ImageList imageListPlayerPhotos;
        private System.Windows.Forms.Label labelExpPercent;
        private System.Windows.Forms.Label labelExpPercentNumber;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonExitGame;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.CheckBox checkBoxToggleMenu;
    }
}

