using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Music.Data.Sql
{
    internal class MusicAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Library.db");
        }

        public DbSet<SongEntity> Books => Set<SongEntity>();
        public DbSet<FavEntity> Checks => Set<FavEntity>();
        public DbSet<UserEntity> Users => Set<UserEntity>();
        public MusicAppContext() => Database.EnsureCreated();

    }
}
