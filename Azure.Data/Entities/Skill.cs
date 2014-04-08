using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.Data.Entities
{
    public class Skill : Entity
    {
        public TimeSpan TimeKnown { get; set; }
    }
}
