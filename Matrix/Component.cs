using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MetaRend.Matrix
{
    public class Component
    {
        public RendObject parent;
        public bool active = true;
    }
    public class ComponentHolder
    {
        private List<Component> components = new List<Component>();
        public List<Component> GetComponents() { return components; }
        public void AddComponent(Component component)
        {
            bool duplicateComponent = false;
            foreach (Component c in components)
            {
                if (component.GetType() == typeof(Components.Transform))
                    throw new System.ArgumentException("Cannot add Transform components.", component.GetType().ToString());
                if (component.GetType() == c.GetType()) duplicateComponent = true;
            }
            if (!duplicateComponent)
                components.Add(component);
            else
                throw new System.ArgumentException("You have a duplicate component: ", component.GetType().ToString());
        }
        public Component GetComponent(Type component)
        {
            if (component == typeof(Components.Transform))
                throw new System.ArgumentException("Use RendObject.transform, a RendObject always has a Transform component.");
            foreach (Component c in components)
            {
                if (component.GetType() == c.GetType())
                    return c;
            }
            throw new System.ArgumentException("No component of type " + component.GetType().ToString() + " exists.");
        }
        public bool HasComponent(Type component)
        {
            if (component == typeof(Components.Transform))
                throw new System.ArgumentException("Use RendObject.transform, a RendObject always has a Transform component.");
            foreach (Component c in components)
            {
                if (component.GetType() == c.GetType())
                    return true;
            }
            return false;
        }
    }
}
