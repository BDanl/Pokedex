using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Util
{
    public static class PokeUtil
    {
        public const string Pokeball1 = "pokeball1.png";
        public const string Pokeball2 = "pokeball2.png";
        public const string Pokeball3 = "pokeball3.png";
        
        public static string RandomBall()
        {
            var ballArray = new string[] { Pokeball1, Pokeball2, Pokeball3};
            var random = new Random();
            string randompkbl = ballArray[random.Next(ballArray.Length)];
            return randompkbl;
        }
       
    }
}