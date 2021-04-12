using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MetaRend
{
    public class CharacterRegistry
    {
        private Dictionary<char, CharacterMatrix> registeredCharacters = new Dictionary<char, CharacterMatrix>();

        private string charactersPath;

        public CharacterRegistry(string charactersPath)
        {
            this.charactersPath = charactersPath;
            registeredCharacters.Add(' ', new CharacterMatrix(8));
            string[] characterRegistryDataLines = File.ReadAllLines(charactersPath + @"\CharacterRegistry.txt");
            foreach (string line in characterRegistryDataLines)
            {
                Console.WriteLine(line);
                string[] registryData = line.Split(' ');
                RegisterLocalCharacterFile(registryData[0][0], registryData[1]);
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
            RegisterCharacterFile(c, charactersPath + @"\" + localPath);
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
