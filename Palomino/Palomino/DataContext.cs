using Common.Models;
using Microsoft.EntityFrameworkCore;

namespace Palomino.Web.Data
{
	public class DataContext : DbContext
	{
		public DbSet<Products> Products { get; set; }

		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
	}
}