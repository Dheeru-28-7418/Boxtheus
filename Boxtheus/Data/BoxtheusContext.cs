using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Boxtheus.Models;

namespace Boxtheus.Data
{
    public class BoxtheusContext : DbContext
    {
        public BoxtheusContext (DbContextOptions<BoxtheusContext> options)
            : base(options)
        {
        }

        public DbSet<Boxtheus.Models.BoxView> BoxView { get; set; }
    }
}
