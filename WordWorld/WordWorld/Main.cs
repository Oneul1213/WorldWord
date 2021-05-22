using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordWorld
{
    public partial class Main : Form
    {
        public Player player = new Player();

        // Main Form Functions
        public Main(Player player = null)
        {
            InitializeComponent();

            // Set Player
            if(player != null)    // exist player
            {
                //this.player.Name = player.Name;
                //this.player.Level = player.Level;

                //this.player = player;

                //this.player.LastEnteredPlace = player.LastEnteredPlace;
                this.player = (Player)player.Clone();
                this.player.PlayerImage = this.imageListPlayers.Images[player.ImageNumber];
            }
            else   // default player
            {
                this.player.Name = "Player";
                this.player.Level = 0;
                this.player.PlayerImage = this.imageListPlayers.Images[0];
            }

            // Set Form
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.labelPlayerName.Text = this.player.Name;

            this.labelLevelNumber.Text = this.player.Level.ToString();

            // set options of progressBarExp
            this.progressBarExp.Maximum = 100 * (this.player.Level);
            this.progressBarExp.Value = (int)this.player.Exp;

            double percentage = 100 * ((double)this.progressBarExp.Value / (double)this.progressBarExp.Maximum);
            this.labelExpPercentNumber.Text = percentage.ToString();

            //this.pictureBoxPlayer.Image = this.player.PlayerImage;
            //this.pictureBoxPlayerPhoto.Image = this.player.PlayerImagePhoto;
            this.pictureBoxPlayer.Image = this.imageListPlayers.Images[player.ImageNumber];
            this.pictureBoxPlayerPhoto.Image = this.imageListPlayerPhotos.Images[player.ImageNumber];
            
        }

        private void ButtonMap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map map = new Map(this.player);
            map.Show();
        }

        public Player GetPlayer()
        {
            return this.player;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LabelQuest_Click(object sender, EventArgs e)
        {
            QuestDialog questDialog = new QuestDialog();
            questDialog.ShowDialog();
        }

        private void CheckBoxToggleMenu_Click(object sender, EventArgs e)
        {
            if (checkBoxToggleMenu.Checked)
            {
                panelMenu.Visible = true;
            }
            else
            {
                panelMenu.Visible = false;
            }
        }

        private void ButtonExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
        }
        
        private void LabelQuest_MouseLeave(object sender, EventArgs e)
        {
            labelQuest.BackColor = SystemColors.Control;
        }

        private void LabelQuest_MouseEnter(object sender, EventArgs e)
        {
            labelQuest.BackColor = SystemColors.ControlLightLight;
        }
    }
}
