using Azure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azure.Data.Entities
{
    public class Consultant : Entity
    {
        public ConsultantType ConsultantType { get; set; }

        public string WorkPhoneNumber { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
