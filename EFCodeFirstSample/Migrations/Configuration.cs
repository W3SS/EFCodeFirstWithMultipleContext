namespace EFCodeFirstSample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using EFCodeFirstSample.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirstSample.DBContexts.StudentDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EFCodeFirstSample.DBContexts.StudentDbContext";
        }

        protected override void Seed(EFCodeFirstSample.DBContexts.StudentDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

			context.Students.AddOrUpdate(
			  p => p.StudentName,
			  new Student { StudentName = "Seed Student Name" }
			);
        }
    }
}
