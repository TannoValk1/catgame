using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using catgame.Core.Domain;
using catgame.Core.ServiceInterface;
using catgame.Data;
using Microsoft.EntityFrameworkCore;

namespace catgame.ApplicationServices.Services
{
    public class CatsServices : ICatsServices
    {
        private readonly catgameContext _context;

        public CatsServices(catgameContext context)
        {
            _context = context;
        }

        public async Task<Cat> DetailsAsync(Guid id)
        {
            var result = await _context.Cats
                .FirstOrDefaultAsync(x => x.ID == id);
            return result;
        }
    }
}
