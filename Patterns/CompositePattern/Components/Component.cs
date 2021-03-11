﻿using System;

namespace CompositeTemplate.Components
{
    abstract class Component
    {
        protected string name;

        public Component(string name) => this.name = name;

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual void Print() => Console.WriteLine(name);
    }
}
