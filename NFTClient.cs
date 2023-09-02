using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Server
{
    public class NFTClient: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;Integrated Security=True") //change according to server
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole())); ;
        }

        public DbSet<mt_Banner> mt_Banners { get; set; }
    }

}
