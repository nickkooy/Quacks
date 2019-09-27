using System;
using System.Collections.Generic;
using System.Text;

namespace Quacks
{
    public class Pot
    {
        public const int MAX_SPACES = 52;
        public const int MAX_CHERRY_BOMBS = 7;
        public int DewDropSpace { get; set; } = 0;
        public int CurrentSpace { get; set; } = 0;
        public int ScoringSpace { get { if (CurrentSpace >= MAX_SPACES) return MAX_SPACES + 1; else return CurrentSpace + 1; } }
        public int RatTails { get; set; } = 0;
        public int MaxCherryBombs { get; set; } = MAX_CHERRY_BOMBS;
        public int TotalCherryBombs { get; set; } = 0;
        public List<Ingredient> Ingredients { get; } = new List<Ingredient>();
        public bool HasExploded { get { return TotalCherryBombs > MaxCherryBombs; } }
        public void RoundReset()
        {
            CurrentSpace = DewDropSpace;
            Ingredients.Clear();
            TotalCherryBombs = 0;
            MaxCherryBombs = MAX_CHERRY_BOMBS;
            RatTails = 0;
        }

        public void GameReset()
        {
            DewDropSpace = 0;
            RoundReset();
        }
    }
}
