using Microsoft.EntityFrameworkCore;
using SpaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaWeb.Context
{
    public class KevenspaDemoContext : DbContext
    {
        public KevenspaDemoContext(DbContextOptions<KevenspaDemoContext> options) : base(options)
        {
        }

        public DbSet<User> db_users { get; set; }
    }

}
