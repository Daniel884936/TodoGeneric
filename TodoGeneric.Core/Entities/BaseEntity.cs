using System;

namespace TodoGeneric.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
