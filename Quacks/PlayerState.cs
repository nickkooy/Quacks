using System;
using System.Collections.Generic;
using System.Text;

namespace Quacks
{
    public class PlayerState
    {
        public Pot Pot { get; private set; }
        public int Rubies { get; set; }
        public List<Ingredient> SetAsideIngredients { get; } = new List<Ingredient>();
        public List<Ingredient> OwnedIngredients { get; }
        public Bag<Ingredient> Bag { get; }

        public PlayerState(IRandom random, IEnumerable<Ingredient> startingIngredients)
        {
            OwnedIngredients = new List<Ingredient>(startingIngredients);
            Bag = new Bag<Ingredient>(random, startingIngredients);
        }
    }
}
