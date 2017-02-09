namespace StudentAssignmentManager.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AssignmentContext : DbContext
    {
        // Your context has been configured to use a 'AssignmentContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'StudentAssignmentManager.Models.AssignmentContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AssignmentContext' 
        // connection string in the application configuration file.
        public AssignmentContext()
            : base("name=AssignmentContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Assignment> Assignments { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}