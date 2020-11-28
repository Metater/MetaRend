using System;
using System.Collections.Generic;
using System.Text;

namespace MetaRend.Matrix
{
    public class RendObject
    {
        public Components.Transform transform;
        public List<Component> components = new List<Component>();
        //public List<Object> children = new List<Object>();
    }
}
