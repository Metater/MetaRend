using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaRend.Matrix
{
    public class RendObject
    {
        public Components.Transform transform = new Components.Transform();
        public ComponentHolder componentHolder = new ComponentHolder();
        //public List<Object> children = new List<Object>();
    } 
    public class RendObjectData
    {
        private Dictionary<string, RendType.Vector2Int> vector2IntDictionary = new Dictionary<string, RendType.Vector2Int>();
        private Dictionary<string, int> intDictionary = new Dictionary<string, int>();
        public 
    }
}
