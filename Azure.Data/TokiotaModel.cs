namespace Azure.Data
{
    using Azure.Data.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TokiotaModel : DbContext
    {
        public TokiotaModel()
            : base("name=TokiotaModel")
        {
        }

        public TokiotaModel(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<Consultant> Consultants { get; set; }

        public virtual DbSet<Project> Projects { get; set; }


        public virtual DbSet<Skill> Skills { get; set; }
    }
}