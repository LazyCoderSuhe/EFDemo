using EFDemo.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseInMemoryDatabase("memory.db");            
        }
        /// <summary>
        ///  数据库表的映射
        /// </summary>
        public DbSet<DbTable> DbTables { get; set; }
    }
}
