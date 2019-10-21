using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingExample.Models
{
    public class SimpleGame
    {
        private int? game1;
        private int? game2;
        public int? Game1 { get => game1; set => ValidateGameScore(value, out game1); }

        private void ValidateGameScore(int? s, out int? game)
        {
            if (!s.HasValue || s < 0 || s > 300)
            {
                throw new ArgumentOutOfRangeException
                    ("scores between 0 and 300 inclusive.");
            }
            game = s.Value;
        }

        public int? Game2 { get => game2; set => ValidateGameScore(value, out game2); }
        public int? Game3 { get; set; }
        public int? Game4 { get; set; }

        public int TotalScore => Game1.GetValueOrDefault()
                    + Game2.GetValueOrDefault()
                    + Game3.GetValueOrDefault()
                    + Game4.GetValueOrDefault();

    }
}
