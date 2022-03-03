using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    class Settings
    {
        public static int speed { get; set; }
        public static int distance { get; set; }
        public static int width { get; set; }
        public static int height { get; set; }
        public static int point { get; set; }
        public static bool game_over { get; set; }
        public static bool game_pause { get; set; }
        public static string direction { get; set; }

        public Settings()
        {
            speed = 2;
            distance = 1;
            width = 20;
            height = 20;
            point = 10;
            game_over = false;
            game_pause = true;
            direction = "";
        }

    }
}
