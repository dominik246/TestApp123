using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using TestApp123.Core.Entities;

namespace TestApp123.Core.DAL
{
    public class Context : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string databaseName = "context.db";
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), databaseName);

            var connectionString = new SqliteConnectionStringBuilder()
            {
                DataSource = databasePath,
            }.ToString();

            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
