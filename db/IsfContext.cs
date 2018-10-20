using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace NASATest2018
{
	public class IsfContext : DbContext
	{
		public DbSet<Report> Reports { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{The entity type 'Comment' requires a primary key to be defined.
			optionsBuilder.UseSqlite("Data Source=isf.db");
		}
	}
}
