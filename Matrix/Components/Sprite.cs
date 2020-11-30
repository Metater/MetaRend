using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace MetaRend.Matrix.Components
{
    public class Sprite : Component
    {
        public enum Cells
        {
            zeroOpaque,
            oneOpaque,
            zeroTranslucent,
            oneTranslucent
        }
        public Cells[,] sprite {get; set; }

        /// Construct a sprite with width, height.
        public Sprite(int width, int height)
        {
            sprite = new Cells[width, height];
        }
        /// Construct a sprite with a 2D Cells array.
        public Sprite(Cells[,] sprite)
        {
            this.sprite = sprite;
        }
    }
}
