using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class TestContext : DbContext
    {
        private readonly string _connectionString;
        public TestContext(string connectionString) : base()
        {
            _connectionString= connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer(_connectionString);
        }
    }
}
