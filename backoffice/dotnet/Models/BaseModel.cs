using System;

namespace dotnet.Models
{
    public class BaseModel : AggregateRoot
    {
        protected BaseModel(string name) : base(Guid.NewGuid(), name)
        {
            var now = DateTime.Now;
            CreatedOn = now;
            UpdatedOn = now;
        }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}