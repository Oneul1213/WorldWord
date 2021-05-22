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
    public partial class Map : Form
    {
        Player currentPlayer = null;
        Place selectedPlace = null;
        Panel selectedPanel = null;

        string backgroundImagePath = @"../../resources/maps/backgrounds/";

        public Map(Player player = null)
        {
            InitializeComponent();

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            try
            {
                if (player != null)
                {
                    this.currentPlayer = (Player)player.Clone();
                    this.pictureBoxPlayer.Image = this.currentPlayer.PlayerImage;
                }
                else throw new Exception("플레이어 정보가 없습니다.");
                
                if(player.LastEnteredPlace == null)
                {
                    this.selectedPlace = new Place("과수원");
                    this.selectedPanel = panelPlace과수원;
                }
                else
                {
                    this.selectedPlace = player.LastEnteredPlace;

                    foreach (Control c in panelMap.Controls)
                    {
                        if (c is Panel)
                        {
                            if (((Panel)c).Name.Equals("panelPlace" + this.selectedPlace.PlaceName))
                            {
                                this.selectedPanel = (Panel)c;
                            }
                        }
                    }
                }
                
                ChangeMapInfoPanel();
                
                // change Location of pictureBoxPlayer
                this.selectedPanel.Controls.Add(pictureBoxPlayer);

                // set background image of map
                this.panelMap.BackgroundImage = Image.FromFile(backgroundImagePath + "background_map_east1_start_1.png");

                // set mapPhoto
                this.pictureBoxMapPhoto.Image = Image.FromFile(this.selectedPlace.MapPhotoFilePath);
            }
            catch(Exception e)
            {
                MessageBox.Show("오류 : " + e.Message);
                return;
            }
            
        }

        private void ChangeMapInfoPanel()
        {
            // Change map info panel
            labelMapName.Text = selectedPlace.PlaceName;

            string mobInfo = String.Join(", ", selectedPlace.GetEnemyList().ToArray());
            labelMobInfo.Text = mobInfo;
        }

        private void Map_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(currentPlayer);
            main.Show();
        }

        private void ButtonEnterMap_Click(object sender, EventArgs e)
        {
            this.currentPlayer.LastEnteredPlace = this.selectedPlace;

            this.Hide();
            Battle battle = new Battle(currentPlayer, selectedPlace.WordFilePath);
            battle.Show();
        }

        private void PanelPlace_Click(object sender, EventArgs e)
        {
            selectedPanel = (Panel)sender;
            string placeName = selectedPanel.Name.Substring(10);

            try
            {
                selectedPlace = new Place(placeName);

                if (selectedPlace == null) throw new Exception("장소 선택에 실패했습니다.");

                ChangeMapInfoPanel();

                // change Location of pictureBoxPlayer
                selectedPanel.Controls.Add(pictureBoxPlayer);

                // set map photo
                this.pictureBoxMapPhoto.Image = Image.FromFile(this.selectedPlace.MapPhotoFilePath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}