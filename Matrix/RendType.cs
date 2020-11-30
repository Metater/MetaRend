using System;
using System.Collections.Generic;
using System.Text;

namespace MetaRend.Matrix.RendType
{
    public class Vector2Int
    {
        public int x;
        public int y;
        public Vector2Int() {}
        public Vector2Int(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public enum Cell
    {
        zeroOpaque,
        oneOpaque,
        zeroTranslucent,
        oneTranslucent
    }
    public enum Rotation
    {
        Up,
        Right,
        Down,
        Left
    }
}
