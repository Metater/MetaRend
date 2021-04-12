using System;
using System.Collections.Generic;
using System.Text;

namespace MetaRend
{
    public class CharacterScroller
    {
        public CharacterRegistry CharacterRegistry { get; private set; }

        public event Action<byte[]> Updated;

        private string text;
        private List<byte> textBytes = new List<byte>();
        private int offset = 0;


        public void Configure(string characterRegistryPath)
        {
            CharacterRegistry = new CharacterRegistry(characterRegistryPath);
        }

        public void SetText(string text)
        {
            this.text = text;
            text =  "        " + text;
            text += "        ";

            foreach (char c in text)
            {
                foreach (byte b in CharacterRegistry.GetCharacterMatrix(c).matrix)
                {
                    textBytes.Add(b);
                }
            }
        }

        public void Update()
        {
            byte[] matrix = new byte[64];
            if (textBytes.Count-65 <= offset) offset = 0;
            for (int i = offset; i < offset + 64; i++)
            {
                matrix[i - offset] = textBytes[i];
            }
            Updated?.Invoke(matrix);
            offset++;
        }
    }
}