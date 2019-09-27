using System;
using System.Collections.Generic;
using System.Text;

namespace Quacks
{
    public abstract class Book
    {
        public Color Color { get; set; }

        public abstract void OnDraw(GameState gameState, PlayerState playerState);
    }
}
