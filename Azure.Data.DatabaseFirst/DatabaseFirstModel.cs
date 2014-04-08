namespace Azure.Data.DatabaseFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseFirstModel : DbContext
    {
        public DatabaseFirstModel()
            : base("name=DatabaseFirstModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
