using Microsoft.EntityFrameworkCore;

namespace WebApp2.Models
{
    public class Context : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\Bryant\Desktop\Projects\DataBases\Users.db");

    }
}
