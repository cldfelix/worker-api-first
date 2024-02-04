using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApiBackgroundServices.Domain.SQLiteModel;

namespace WebApiBackgroundServices.Repository
{
    public class SQLiteContext: DbContext
    {
        public SQLiteContext(DbContextOptions<SQLiteContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=WebApiBackgroundServices.db;Cache=Shared");

        public DbSet<Message> Messages { get; set; }

    }
}
