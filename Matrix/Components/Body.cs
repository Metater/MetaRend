using System;
using System.Collections.Generic;
using System.Text;

namespace MetaRend.Matrix.Components
{
    public class Body : Component
    {
        public RendType.Vector2Int velocity;
        public int rotationSpeed;
        public Body() {}
        public Body(RendType.Vector2Int velocity, int rotationSpeed)
        {
            this.velocity = velocity;
            this.rotationSpeed = rotationSpeed;
        }
    }
}
