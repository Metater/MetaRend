using System;

namespace MetaRend
{
    public class CharacterMatrix
    {
        public int width;
        public byte[] matrix { get; private set; }

        public CharacterMatrix(int width)
        {
            matrix = new byte[width];
        }
        public CharacterMatrix(string data)
        {
            string[] rows = data.Split('\n', '\r');
            width = rows[0].Length;
            matrix = new byte[width];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    matrix[x] = (byte)(matrix[x] << 1);
                    if (rows[y][x] == '1') { matrix[x] |= 0x01; }
                }
            }
        }
    }
}
