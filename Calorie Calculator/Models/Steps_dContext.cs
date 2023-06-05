using Microsoft.EntityFrameworkCore;
namespace Calorie_Calculator.Models
{
    public class Steps_dContext : DbContext
    {
        public Steps_dContext(DbContextOptions<Steps_dContext> options) : base(options)
        {
        }
        public DbSet<Steps_d> Steps_Ds  {get; set;}
    }
}
