using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MetaRend
{
    public class CharacterRegistry
    {
        private Dictionary<char, CharacterMatrix> registeredCharacters = new Dictionary<char, CharacterMatrix>();

        public CharacterRegistry(string characterRegistryData)
        {
            registeredCharacters.Add(' ', new CharacterMatrix(8));
            string[] characterRegistryDataLines = characterRegistryData.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in characterRegistryDataLines)
            {
                string[] registryData = line.Split(' ');
            }
        }

        #region Registering
        public void RegisterCharacter(char c, CharacterMatrix matrix)
        {
            registeredCharacters.Add(c, matrix);
        }

        public void RegisterCharacterFile(char c, string path)
        {
            string characterData = File.ReadAllText(path);
            RegisterCharacter(c, new CharacterMatrix(characterData));
        }

        public void RegisterLocalCharacterFile(char c, string localPath)
        {
            string localDir = Directory.GetCurrentDirectory();
            RegisterCharacterFile(c, localDir + @"\" + localPath);
        }
        #endregion Registering

        #region GetMethods
        public CharacterMatrix GetCharacterMatrix(char c)
        {
            return registeredCharacters[c];
        }
        #endregion GetMethods
    }
}
