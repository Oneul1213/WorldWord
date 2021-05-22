namespace WordWorld
{
    partial class Battle
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
            this.components = new System.ComponentModel.Container();
            this.progressBarAchievement = new System.Windows.Forms.ProgressBar();
            this.labelAchievement = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelSpliter1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSpliter2 = new System.Windows.Forms.Label();
            this.panelBattle = new System.Windows.Forms.Panel();
            this.timerGenerateWord = new System.Windows.Forms.Timer(this.components);
            this.timerMoveWord = new System.Windows.Forms.Timer(this.components);
            this.imageListEnemy = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // progressBarAchievement
            // 
            this.progressBarAchievement.Location = new System.Drawing.Point(112, 9);
            this.progressBarAchievement.Name = "progressBarAchievement";
            this.progressBarAchievement.Size = new System.Drawing.Size(684, 39);
            this.progressBarAchievement.TabIndex = 0;
            // 
            // labelAchievement
            // 
            this.labelAchievement.Font = new System.Drawing.Font("나눔고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAchievement.Location = new System.Drawing.Point(9, 12);
            this.labelAchievement.Name = "labelAchievement";
            this.labelAchievement.Size = new System.Drawing.Size(97, 36);
            this.labelAchievement.TabIndex = 1;
            this.labelAchievement.Text = "달성률";
            // 
            // textBoxWord
            // 
            this.textBoxWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxWord.Font = new System.Drawing.Font("나눔고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxWord.Location = new System.Drawing.Point(12, 402);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(520, 39);
            this.textBoxWord.TabIndex = 2;
            this.textBoxWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxWord_KeyDown);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonEnter.Location = new System.Drawing.Point(538, 402);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(123, 37);
            this.buttonEnter.TabIndex = 3;
            this.buttonEnter.Text = "입력";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // labelSpliter1
            // 
            this.labelSpliter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSpliter1.Location = new System.Drawing.Point(2, 58);
            this.labelSpliter1.Name = "labelSpliter1";
            this.labelSpliter1.Size = new System.Drawing.Size(800, 2);
            this.labelSpliter1.TabIndex = 4;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonExit.Location = new System.Drawing.Point(667, 402);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(123, 37);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "나가기";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // labelSpliter2
            // 
            this.labelSpliter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSpliter2.Location = new System.Drawing.Point(1, 389);
            this.labelSpliter2.Name = "labelSpliter2";
            this.labelSpliter2.Size = new System.Drawing.Size(800, 2);
            this.labelSpliter2.TabIndex = 7;
            // 
            // panelBattle
            // 
            this.panelBattle.Location = new System.Drawing.Point(2, 58);
            this.panelBattle.Name = "panelBattle";
            this.panelBattle.Size = new System.Drawing.Size(799, 333);
            this.panelBattle.TabIndex = 8;
            // 
            // timerGenerateWord
            // 
            this.timerGenerateWord.Tick += new System.EventHandler(this.TimerGenerateWord_Tick);
            // 
            // timerMoveWord
            // 
            this.timerMoveWord.Tick += new System.EventHandler(this.TimerMoveWord_Tick);
            // 
            // imageListEnemy
            // 
            this.imageListEnemy.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListEnemy.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListEnemy.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.panelBattle);
            this.Controls.Add(this.labelSpliter2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelSpliter1);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.labelAchievement);
            this.Controls.Add(this.progressBarAchievement);
            this.Name = "Battle";
            this.Text = "WordWorld - Battle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Battle_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarAchievement;
        private System.Windows.Forms.Label labelAchievement;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelSpliter1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSpliter2;
        private System.Windows.Forms.Panel panelBattle;
        private System.Windows.Forms.Timer timerGenerateWord;
        private System.Windows.Forms.Timer timerMoveWord;
        private System.Windows.Forms.ImageList imageListEnemy;
    }
}