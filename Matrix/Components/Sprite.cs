using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace MetaRend.Matrix.Components
{
    public class Sprite : Component
    {
        public RendType.Cell[,] sprite;
        public bool isInversionMask = false;

        /// <summary>
        /// Construct a null sprite.
        /// </summary>
        public Sprite() { }
        /// <summary>
        /// Construct a sprite with width, height.
        /// </summary>
        public Sprite(int width, int height)
        {
            sprite = new RendType.Cell[width, height];
        }
        /// <summary>
        /// Construct a sprite with a 2D Cells array.
        /// </summary>
        public Sprite(RendType.Cell[,] sprite)
        {
            this.sprite = sprite;
        }
    }
}
