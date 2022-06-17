using System;
using Microsoft.EntityFrameworkCore;
namespace PropertyManager.Db
{
	public class PropertyContext : DbContext
	{
		public PropertyContext(DbContextOptions<PropertyContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
	}
}

