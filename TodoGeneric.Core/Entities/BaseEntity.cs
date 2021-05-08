using System;
using System.Collections.Generic;
using System.Text;

namespace TodoGeneric.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
