using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaRend.Matrix
{
    public class RendObject
    {
        public string name;
        public Components.Transform transform = new Components.Transform();
        public ComponentHolder componentHolder = new ComponentHolder();
        //public List<Object> children = new List<Object>();
        public RendObjectData rendObjectData;
    } 
    public class RendObjectData
    {
        private Dictionary<string, RendType.Vector2Int> vector2IntDictionary = new Dictionary<string, RendType.Vector2Int>();
        private Dictionary<string, int> intDictionary = new Dictionary<string, int>();
        // Add
        public void AddVector2Int(string key, RendType.Vector2Int value) { vector2IntDictionary.Add(key, value); }
        public void AddInt(string key, int value) { intDictionary.Add(key, value); }
        // Get
        public RendType.Vector2Int GetVector2Int(string key) { return vector2IntDictionary[key]; }
        public int GetInt(string key) { return intDictionary[key]; }
        // Set
        public void SetVector2Int(string key, RendType.Vector2Int value) { vector2IntDictionary[key] = value; }
        public void SetInt(string key, int value) { intDictionary[key] = value; }
        // Exists
        public bool Vector2IntKeyExists(string key) { return vector2IntDictionary.ContainsKey(key); }
        public bool IntKeyExists(string key) { return intDictionary.ContainsKey(key); }
        public bool Vector2IntValueExists(RendType.Vector2Int value) { return vector2IntDictionary.ContainsValue(value); }
        public bool IntValueExists(int value) { return intDictionary.ContainsValue(value); }
    }
}
