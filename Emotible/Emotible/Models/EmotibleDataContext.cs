using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Emotible.Models
{
    public class EmotibleDataContext : DbContext
    {
        public DbSet<Emote> Emotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Emotible.db");
        }
    }
}
