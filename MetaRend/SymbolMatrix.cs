using System;

namespace MetaRend
{
    public class SymbolMatrix
    {
        public int width;
        public byte[] matrix { get; private set; }

        public SymbolMatrix(int width)
        {
            matrix = new byte[width];
        }
        public SymbolMatrix(string data)
        {
            string[] rows = data.Split('\n');
            width = rows[0].Length;
            matrix = new byte[width];
            for (int y = 0; y < 8; y++)
            {
                matrix[y] = 0x00;
                for (int x = 0; x < width; x++)
                {
                    char c = rows[y][x];
                    if (c == '0')
                    {
                        matrix[y] = (byte)(matrix[y] << 1);
                    }
                    else if (c == '1')
                    {
                        matrix[y] |= 0x01;
                        matrix[y] = (byte)(matrix[y] << 1);
                    }
                    else throw new Exception($"Unrecognised character: {c} in symbol matrix!");
                }
            }
        }
        public SymbolMatrix(string data, int i)
        {
            string[] rows = data.Split('\n', '\r');
            width = rows[0].Length;
            matrix = new byte[width];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    matrix[x] = unchecked((byte)(matrix[x] << 1));
                    char c = rows[y][x];
                    if (c == '1') { matrix[x] |= 0x01; }
                }
            }
        }
    }
}
