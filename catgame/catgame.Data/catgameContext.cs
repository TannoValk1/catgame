using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catgame.Data
{
    public class catgameContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }
    }
}
