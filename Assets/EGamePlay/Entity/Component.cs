﻿using System;

namespace EGamePlay
{
    public class Component : IDisposable
    {
        public Entity Entity { get; set; }
        public bool IsDispose { get; set; }


        public T GetEntity<T>() where T : Entity
        {
            return Entity as T;
        }

        public virtual void Setup()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Dispose()
        {
            IsDispose = true;
        }
    }
}