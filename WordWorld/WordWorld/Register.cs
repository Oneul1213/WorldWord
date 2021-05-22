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
    public partial class Register : Form
    {
        StreamReader streamReader;
        StreamWriter streamWriter;

        string playersFilePath = @"../../resources/players/";

        public Register()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
        }

        // Placeholder
        private void TextBoxID_Enter(object sender, EventArgs e)
        {
            if (textBoxID.ForeColor == Color.FromArgb(224, 224, 224))
            {
                textBoxID.Text = "";
                textBoxID.ForeColor = SystemColors.ControlText;
            }
        }

        private void TextBoxID_Leave(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                textBoxID.Text = "ID";
                textBoxID.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.ForeColor == Color.FromArgb(224, 224, 224))
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = SystemColors.ControlText;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxID.ForeColor == Color.FromArgb(224, 224, 224))
            {
                MessageBox.Show("ID를 입력하세요.");
                return;
            }

            // Confirm that the ID exists
            using (streamReader = new StreamReader(playersFilePath + "playerList.txt"))
            {
                string playerName = null;
                while ((playerName = streamReader.ReadLine()) != null)
                {
                    if (playerName == textBoxID.Text) break;
                }

                if (playerName != null)
                {
                    MessageBox.Show("ID가 이미 존재합니다!");
                    return;
                }
            }

            // Register new player
            try
            {
                Player newPlayer = new Player(textBoxID.Text, textBoxPassword.Text, 0);

                using (streamWriter = new StreamWriter(playersFilePath + "playerList.txt", true))
                {
                    streamWriter.WriteLine(textBoxID.Text);
                }

                // Make playerID file and write player information
                Player.SavePlayerInfo(playersFilePath, newPlayer);
                
                MessageBox.Show("등록 완료");
                ButtonGoBack_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 : " + ex.Message);
                return;
            }
        }

        private void TextBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // Ignore enter
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonRegister_Click(sender, e);
            }
        }
    }
}
