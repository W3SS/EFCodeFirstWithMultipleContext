namespace EFCodeFirstSample.TeacherMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using EFCodeFirstSample.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirstSample.DBContexts.TeacherDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"TeacherMigrations";
            ContextKey = "EFCodeFirstSample.DBContexts.TeacherDbContext";
        }

        protected override void Seed(EFCodeFirstSample.DBContexts.TeacherDbContext context)
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

			context.Teachers.AddOrUpdate(
			  p => p.TeacherName,
			  new Teacher { TeacherName = "Seed Teacher Name" }
			);
			
        }
    }
}
