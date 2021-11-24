using System.Collections.Generic;
using System.Linq;

namespace Hubi
{
    public class Player
    {


        public PlayerColor PlayerColor { get; set; }

        public PlayerType PlayerType { get; set; }

        public int StartPosX { get; set; }
        public int StartPosY { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public List<Point> VisitedFields { get; set; }

        public char ViewChar { get; set; }

        public static Player CreatePlayer(char code)
        {
            Player player = null;
            Field field = null;
            if (code == 'r')
            {
                player = new Player() { PlayerColor = PlayerColor.Red, PlayerType = PlayerType.Mouse };
                player.StartPosX = 3; player.PosX = 3;
                player.StartPosY = 0; player.PosY = 0;
                player.ViewChar = '2';
            }
            else if (code == 'b')
            {
                player = new Player() { PlayerColor = PlayerColor.Blue, PlayerType = PlayerType.Rabbit };
                player.StartPosX = 0; player.PosX = 0;
                player.StartPosY = 3; player.PosY = 3;
                player.ViewChar = '3';
            }
            else if (code == 'y')
            {
                player = new Player() { PlayerColor = PlayerColor.Yellow, PlayerType = PlayerType.Mouse };
                player.StartPosX = 3; player.PosX = 3;
                player.StartPosY = 3; player.PosY = 3;
                player.ViewChar = '4';
            }
            else if (code == 'g')
            {
                player = new Player() { PlayerColor = PlayerColor.Green, PlayerType = PlayerType.Rabbit };
                player.StartPosX = 0; player.PosX = 0;
                player.StartPosY = 0; player.PosY = 0;
                player.ViewChar = '1';
            }
            player.VisitedFields = new List<Point>();
            player.VisitedFields.Add(new Point(player.PosX, player.PosY));
            return player;
        }

        public bool AddVisitedField(int x, int y)
        {
            var alreadyVisited = VisitedFields.SingleOrDefault(f => f.X == x && f.Y == y);
            if (alreadyVisited != null)
                return true;
            VisitedFields.Add(new Point(x, y));
            return false;
        }
    }
}