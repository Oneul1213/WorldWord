using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace WordWorld
{
    [Serializable]
    public class Player : ICloneable
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        public double Exp { get; set; }
        public int ImageNumber { get; set; }
        public Image PlayerImage { get; set; }
        public Place LastEnteredPlace { get; set; }

        public Player(string name = "player", string password = "1234", int imageNumber = 0, int level = 1, double exp = 0.0)
        {
            this.Name = name;
            this.Password = password;
            this.ImageNumber = imageNumber;

            this.Level = level;
            this.Exp = exp;

            this.LastEnteredPlace = null;
        }

        public object Clone()
        {
            Player player = new Player();
            player.Name = this.Name;
            player.Password = this.Password;
            player.Level = this.Level;
            player.Exp = this.Exp;
            player.ImageNumber = this.ImageNumber;
            player.PlayerImage = this.PlayerImage;
            player.LastEnteredPlace = this.LastEnteredPlace;

            return player;
        }

        public static void SavePlayerInfo(string playersFilePath, Player player)
        {
            using (FileStream fileStream = new FileStream(@playersFilePath + "info/" + player.Name, FileMode.Create))
            {
                byte[] bytes = Serializer.Serailze(player);
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    fileStream.Position = 0;

                    foreach (byte b in bytes)
                    {
                        binaryWriter.Write(b);
                    }
                }
            }
        }

        public static Player LoadPlayerInfo(string playerInfoFilePath, int fileSize)
        {
            using(FileStream fileStream = new FileStream(@playerInfoFilePath, FileMode.Open))
            {
                using(BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    fileStream.Position = 0;

                    byte[] bytes = binaryReader.ReadBytes(fileSize);

                    Player outputPlayer = (Player)Serializer.Deserialize(bytes);

                    return outputPlayer;
                }
            }
        }
    }
}
