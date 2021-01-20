using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid().ToString("N").ToUpper();
        }

        public string Id { get; private set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}

