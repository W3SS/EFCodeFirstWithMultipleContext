using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirstSample.Models;

namespace EFCodeFirstSample.DBContexts
{
	public class StudentDbContext: DbContext
	{
		public StudentDbContext() 
			: base("EFCodeFirstConnString") 
		{
			
		}

		public DbSet<Student> Students { get; set; }
	}
}
