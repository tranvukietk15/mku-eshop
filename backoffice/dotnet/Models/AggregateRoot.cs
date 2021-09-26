using System;

namespace dotnet.Models
{
    public abstract class AggregateRoot
    {   
        protected AggregateRoot(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
    }
}