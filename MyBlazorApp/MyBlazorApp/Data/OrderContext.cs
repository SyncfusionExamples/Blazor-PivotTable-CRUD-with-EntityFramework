using Microsoft.EntityFrameworkCore;


namespace MyBlazorApp.Data
{
    public class OrderContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + @"\App_Data\NORTHWND.MDF;Integrated Security=True");
            }
        }
    }
 
}
