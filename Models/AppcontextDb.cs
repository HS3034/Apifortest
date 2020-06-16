using Microsoft.EntityFrameworkCore;
namespace Apifortest.Models
{
    public class AppcontextDb :DbContext
    {
        public AppcontextDb(DbContextOptions<AppcontextDb> options) :base(options){

        }
        public DbSet<member>members{get;set;}
        
    }
}