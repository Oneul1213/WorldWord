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
    public partial class StartMenu : Form
    {
        StreamReader streamReader;
        int fileSize = 1024 * 1024;

        string playersFilePath = @"../../resources/players/";

        Player loginPlayer = null;

        public StartMenu()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Focus textBoxID
            this.ActiveControl = textBoxID;
            textBoxID.Focus();
        }

        private void StartMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if(textBoxID.ForeColor == Color.FromArgb(224, 224, 224))
            {
                MessageBox.Show("ID를 입력하세요.");
                return;
            }

            string playerName = null;

            // Confirm that the ID exists
            try
            {
                using (streamReader = new StreamReader(playersFilePath + "playerList.txt"))
                {
                    while ((playerName = streamReader.ReadLine()) != null)
                    {
                        if (playerName == textBoxID.Text) break;
                    }

                    if (playerName == null)
                    {
                        MessageBox.Show("존재하지 않는 ID입니다.");
                        streamReader.Close();
                        return;
                    }
                }

                // Check password
                
                string playerInfoFilePath = @playersFilePath + "info/" + playerName;
                if (!(File.Exists(playerInfoFilePath)))
                {
                    //File.Create(playerInfoFilePath);
                    throw new Exception("존재하지 않는 플레이어");
                }

                // Read playerID file
                Player player = Player.LoadPlayerInfo(playerInfoFilePath, fileSize);

                if (player.Password == textBoxPassword.Text)
                {
                    loginPlayer = (Player)player.Clone();

                    // Open Main Form
                    this.Hide();
                    Main main = new Main(loginPlayer);
                    main.Show();
                }
                else
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다.");
                    textBoxPassword.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 : " + ex.Message);
                return;
            }
        }

        private void ButtonDoRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        // Placeholder
        private void TextBoxID_Enter(object sender, EventArgs e)
        {
            if(textBoxID.ForeColor == Color.FromArgb(224, 224, 224))
            {
                textBoxID.Text = "";
                textBoxID.ForeColor = SystemColors.ControlText;
            }
        }

        private void TextBoxID_Leave(object sender, EventArgs e)
        {
            if(textBoxID.Text == "")
            {
                textBoxID.Text = "ID";
                textBoxID.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if(textBoxPassword.ForeColor == Color.FromArgb(224, 224, 224))
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = SystemColors.ControlText;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "")
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void TextBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ignore enter
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonStart_Click(sender, e);
            }
        }
    }
}
