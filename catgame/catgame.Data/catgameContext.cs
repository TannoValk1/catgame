using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using catgame.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace catgame.Data
{
    public class catgameContext : DbContext
    {
        public catgameContext(DbContextOptions<catgameContext> options) : base(options){}
        public DbSet<Cat> Cats { get; set; }
    }
}
