using System;
using System.Collections.Generic;
using System.Text;

namespace MetaRend.Matrix.Components
{
    public class Transform : Component
    {
        public RendType.Vector2Int position = new RendType.Vector2Int();
        public RendType.Rotation rotation = RendType.Rotation.Up;
        public Transform() {}
        public Transform(RendType.Vector2Int position, RendType.Rotation rotation)
        {
            this.position = position;
            this.rotation = rotation;
        }
    }
}
