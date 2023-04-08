using System;
using Microsoft.EntityFrameworkCore;

namespace MVCCoreTutorialDemo.Models.Domain
{
	public class DatabaseContext: DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> opts): base(opts)
		{
			
		}

		public DbSet<Person> person { get; set; }

	}
}

