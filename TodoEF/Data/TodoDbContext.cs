using Microsoft.EntityFrameworkCore;
using TodoEF.Model;

namespace TodoEF.Data
{
	public class TodoDbContext : DbContext
	{
		public DbSet<Todo> TodoApp { get; set; } = null;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TodoEF_Db;Integrated Security=True");
		}


	}
}
