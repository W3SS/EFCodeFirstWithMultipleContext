using System.Data.Entity;
using EFCodeFirstSample.Models;

namespace EFCodeFirstSample.DBContexts
{
	public class TeacherDbContext : DbContext
	{
		public TeacherDbContext()
			: base("EFCodeFirstConnString")
		{ 
			
		}

		public DbSet<Teacher> Teachers { get; set; }
	}
}
