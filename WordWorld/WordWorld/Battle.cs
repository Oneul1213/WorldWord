using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WordWorld
{
    public partial class Battle : Form
    {
        Player currentPlayer = null;

        List<string> mapWordList = new List<string>();
        List<Label> liveLabelList = new List<Label>();

        StreamReader streamReader = null;

        Random randomPosition, randomWord, randomExp;

        string wordFilePath = @"../../resources/words/town1.txt";
        string playersFilePath = "../../resources/players/";

        double collectedExp = 0.0;

        public Battle(Player player = null, string path = null)
        {
            InitializeComponent();
            InitializeBattle(path);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            try
            {
                if (player != null)
                {
                    this.currentPlayer = (Player)player.Clone();
                }
                else throw new Exception("플레이어 정보가 없습니다.");
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            randomPosition = new Random(DateTime.Now.Millisecond);
            randomWord = new Random(DateTime.Now.Millisecond);
        }

        private void InitializeBattle(string path)
        {
            try
            {
                // set wordFilePath
                if (path == null) throw new Exception("적 파일 경로가 올바르지 않습니다.");

                this.wordFilePath = path;
                
                // set mapWordList
                streamReader = new StreamReader(wordFilePath);

                string word;
                while ((word = streamReader.ReadLine()) != null)
                {
                    mapWordList.Add(word);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("오류 : " + e.Message);
                return;
            }

            // set timers
            timerGenerateWord.Interval = 1000;
            timerGenerateWord.Enabled = true;

            timerMoveWord.Interval = 500;
            timerMoveWord.Enabled = true;

            // set progressbar
            progressBarAchievement.Value = 0;
            progressBarAchievement.Maximum = 10;
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            string enteredText = textBoxWord.Text;
            textBoxWord.Clear();

            // Delete Entered Label
            foreach (Label item in liveLabelList)
            {
                if (item.Text == enteredText)
                {
                    // remove label
                    panelBattle.Controls.Remove(item);
                    liveLabelList.Remove(item);
                    item.Dispose();

                    // give exp to player
                    randomExp = new Random(DateTime.Now.Millisecond);
                    double Exp = (randomExp.NextDouble() * 2.0 + 1.7);
                    //currentPlayer.Exp += 3.7;
                    collectedExp += Exp;

                    // increase progressbar value
                    if (progressBarAchievement.Value < 10)
                    {
                        progressBarAchievement.Value += 1;
                    }
                    else
                    {
                        currentPlayer.Exp += collectedExp;

                        // check level up
                        if(currentPlayer.Exp >= 100*currentPlayer.Level)
                        {
                            currentPlayer.Exp -= 100 * currentPlayer.Level;
                            currentPlayer.Level += 1;
                        }

                        ButtonExit_Click(sender, e);
                        MessageBox.Show("승리!");
                    }

                    break;
                }
            }
        }

        private void Battle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ButtonEnter_Click(sender, e);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {

            collectedExp = 0.0;

            // save player info
            Player.SavePlayerInfo(playersFilePath, currentPlayer);

            // reset controls
            mapWordList.Clear();
            liveLabelList.Clear();
            timerGenerateWord.Enabled = false;
            timerMoveWord.Enabled = false;

            streamReader.Close();

            // show new form
            this.Hide();
            Map map = new Map(currentPlayer);
            map.Show();
        }

        private void TimerGenerateWord_Tick(object sender, EventArgs e)
        {
            // mapWordList to liveLabelList
            int nthWord = randomWord.Next(0, mapWordList.Count);

            // put new word to screen
            int nthPosition = randomPosition.Next(0, 10);

            Label labelNewWord = new Label
            {
                Text = mapWordList[nthWord],
                Location = new Point(80 * nthPosition, 15)
            };

            panelBattle.Controls.Add(labelNewWord);
            liveLabelList.Add(labelNewWord);
        }

        private void TimerMoveWord_Tick(object sender, EventArgs e)
        {
            foreach(Label item in liveLabelList)
            {
                int X = item.Location.X;
                int Y = item.Location.Y;

                Y += 10;

                item.Location = new Point(X, Y);
            }
        }
    }
}
