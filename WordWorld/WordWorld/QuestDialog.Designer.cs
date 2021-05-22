namespace WordWorld
{
    partial class QuestDialog
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
            this.labelQuestListTitle = new System.Windows.Forms.Label();
            this.listBoxQuestList = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetReward = new System.Windows.Forms.Button();
            this.labelQuestContentTitle = new System.Windows.Forms.Label();
            this.labelQuestContent = new System.Windows.Forms.Label();
            this.labelQuestReward = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestListTitle
            // 
            this.labelQuestListTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuestListTitle.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelQuestListTitle.Location = new System.Drawing.Point(13, 13);
            this.labelQuestListTitle.Name = "labelQuestListTitle";
            this.labelQuestListTitle.Size = new System.Drawing.Size(187, 41);
            this.labelQuestListTitle.TabIndex = 0;
            this.labelQuestListTitle.Text = "의뢰";
            this.labelQuestListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxQuestList
            // 
            this.listBoxQuestList.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxQuestList.FormattingEnabled = true;
            this.listBoxQuestList.ItemHeight = 15;
            this.listBoxQuestList.Location = new System.Drawing.Point(13, 58);
            this.listBoxQuestList.Name = "listBoxQuestList";
            this.listBoxQuestList.Size = new System.Drawing.Size(187, 154);
            this.listBoxQuestList.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonClose.Location = new System.Drawing.Point(140, 249);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(123, 42);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "닫기";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonGetReward
            // 
            this.buttonGetReward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGetReward.Enabled = false;
            this.buttonGetReward.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonGetReward.Location = new System.Drawing.Point(347, 249);
            this.buttonGetReward.Name = "buttonGetReward";
            this.buttonGetReward.Size = new System.Drawing.Size(123, 42);
            this.buttonGetReward.TabIndex = 3;
            this.buttonGetReward.Text = "보상 받기";
            this.buttonGetReward.UseVisualStyleBackColor = true;
            // 
            // labelQuestContentTitle
            // 
            this.labelQuestContentTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuestContentTitle.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelQuestContentTitle.Location = new System.Drawing.Point(206, 13);
            this.labelQuestContentTitle.Name = "labelQuestContentTitle";
            this.labelQuestContentTitle.Size = new System.Drawing.Size(404, 41);
            this.labelQuestContentTitle.TabIndex = 4;
            this.labelQuestContentTitle.Text = "의뢰 이름";
            this.labelQuestContentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQuestContent
            // 
            this.labelQuestContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuestContent.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelQuestContent.Location = new System.Drawing.Point(206, 58);
            this.labelQuestContent.Name = "labelQuestContent";
            this.labelQuestContent.Size = new System.Drawing.Size(404, 110);
            this.labelQuestContent.TabIndex = 5;
            this.labelQuestContent.Text = "의뢰 내용";
            // 
            // labelQuestReward
            // 
            this.labelQuestReward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuestReward.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelQuestReward.Location = new System.Drawing.Point(206, 171);
            this.labelQuestReward.Name = "labelQuestReward";
            this.labelQuestReward.Size = new System.Drawing.Size(404, 41);
            this.labelQuestReward.TabIndex = 6;
            this.labelQuestReward.Text = "보상";
            this.labelQuestReward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuestDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(622, 303);
            this.Controls.Add(this.labelQuestReward);
            this.Controls.Add(this.labelQuestContent);
            this.Controls.Add(this.labelQuestContentTitle);
            this.Controls.Add(this.buttonGetReward);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.listBoxQuestList);
            this.Controls.Add(this.labelQuestListTitle);
            this.Name = "QuestDialog";
            this.Text = "WordWorld - QuestDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestListTitle;
        private System.Windows.Forms.ListBox listBoxQuestList;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGetReward;
        private System.Windows.Forms.Label labelQuestContentTitle;
        private System.Windows.Forms.Label labelQuestContent;
        private System.Windows.Forms.Label labelQuestReward;
    }
}