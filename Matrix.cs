using System;
using System.Collections.Generic;
using System.Text;

namespace MetaRend.Matrix
{
    public class Matrix
    {
        public bool[,] matrix;
        public List<RendObject> matrixObjects = new List<RendObject>();
        public Matrix(int width, int height)
        {
            matrix = new bool[width, height];
        }
        public void Update()
        {

        }
    }
}
