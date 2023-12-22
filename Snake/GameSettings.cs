using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class GameSettings
    {
        public static double WallDensity { get; set; } = 0.05;
        public static bool WallFatality { get; set; } = true;
    }
}
