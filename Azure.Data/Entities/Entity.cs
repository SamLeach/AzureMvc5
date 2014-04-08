using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.Data.Entities
{
    /// <summary>
    /// All Entity Framework Entities inherit from this base Entity. Holds properties common to all entities.
    /// </summary>
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public string Name { get; set; }
    }
}
