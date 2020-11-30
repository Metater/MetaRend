using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaRend.Matrix
{
    public class Component
    {
        public bool active = true;
    }
    public class ComponentHolder
    {
        private List<Component> components = new List<Component>();
        public List<Component> GetComponents() { return components; }
        public bool TryAddComponent(Component component)
        {
            foreach (Component c in components)
                if (component.GetType() == c.GetType()) return false;
            components.Add(component);
            return true;
        }
    }
}
