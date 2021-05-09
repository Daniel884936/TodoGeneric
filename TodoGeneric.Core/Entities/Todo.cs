using TodoGeneric.Core.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TodoGeneric.Entities.Todo
{
    public partial class Todo: BaseEntity 
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
