using System;

namespace dotnet.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            
        }
        
        protected BaseModel(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        protected Guid Id { get; private set; }
        protected string Name { get; private set; }
    }
}