using System;
using System.Data.Entity;
using EFCodeFirstSample.DBContexts;
using EFCodeFirstSample.Migrations;
using EFCodeFirstSample.Models;

namespace EFCodeFirstSample
{
	class Program
	{
		static void Main(string[] args)
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentDbContext, Configuration>());
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<TeacherDbContext, TeacherMigrations.Configuration>());

			using (var studentContext = new StudentDbContext())
			{
				Console.Write("please input student's name: ");
				var name = Console.ReadLine();
				var student = new Student()
				{
					StudentName = name
				};

				studentContext.Students.Add(student);
				studentContext.SaveChanges();
			}

			using (var teacherContext = new TeacherDbContext())
			{
				Console.Write("please input teacher's name: ");
				var name = Console.ReadLine();
				var teacher = new Teacher()
				{
					TeacherName = name
				};

				teacherContext.Teachers.Add(teacher);
				teacherContext.SaveChanges();
			}

			Console.ReadLine();
		}
	}
}
