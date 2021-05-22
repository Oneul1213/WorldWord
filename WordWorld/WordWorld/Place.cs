using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WordWorld
{
    [Serializable]
    public class Place
    {
        public string WordFilePath { get; set; }
        public string Region { get; set; }
        public string Town { get; set; }
        public string PlaceName { get; set; }
        public string MapPhotoFilePath { get; set; }

        public Place(string placeName)
        {
            this.WordFilePath = @"../../resources/maps/";
            this.MapPhotoFilePath = @"../../resources/maps/mapPhoto/";

            try
            {
                using (StreamReader streamReader = new StreamReader(WordFilePath + "PlaceList.txt"))
                {
                    string reversedPath = null;
                    string[] mapInfoArray;
                    while((reversedPath = streamReader.ReadLine()) != null)
                    {
                        mapInfoArray = reversedPath.Split('/');

                        if (mapInfoArray[0].Equals(placeName))
                        {
                            this.Region = mapInfoArray[2];
                            this.Town = mapInfoArray[1];
                            this.PlaceName = mapInfoArray[0];

                            this.WordFilePath += ("info/" + this.Region + '/' + this.Town + '/' + this.PlaceName + ".txt");
                            this.MapPhotoFilePath += (this.Region + '/' + this.Town + '/' + this.PlaceName + ".png");
                            break;
                        }
                    }
                }

                if (this.WordFilePath.Equals(@"../../resources/maps/")) throw new Exception("파일을 찾지 못했습니다.");
            }
            catch(Exception e)
            {
                MessageBox.Show("오류 : " + e.Message);
                return;
            }
        }

        public List<string> GetEnemyList()
        {
            List<string> enemyList = new List<string>();

            try
            {
                using (StreamReader streamReader = new StreamReader(@WordFilePath))
                {
                    string enemy;
                    while ((enemy = streamReader.ReadLine()) != null)
                    {
                        enemyList.Add(enemy);
                    }
                }

                return enemyList;
            }
            catch(Exception e)
            {
                MessageBox.Show("오류 : " + e.Message);
                return null;
            }
        }
    }
}
