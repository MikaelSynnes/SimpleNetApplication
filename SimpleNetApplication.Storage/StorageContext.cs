using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleNetApplication.Storage.Models;

namespace SimpleNetApplication.Storage
{
    public class StorageContext: DbContext
    {
        public DbSet<SimpleDbModel> SimpleModels { get; set; }
        public StorageContext()
        {
            Database.Migrate();
        }
        public StorageContext(DbContextOptions<StorageContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            string dir = @"C:\simpleapp";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            optionbuilder.UseSqlite(@"Data Source=c:\simpleapp\Simple.db");
        }
    }
}
