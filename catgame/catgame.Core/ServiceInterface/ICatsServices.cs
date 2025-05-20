using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using catgame.Core.Domain;

namespace catgame.Core.ServiceInterface
{
    public interface ICatsServices
    {
        Task<Cat> DetailsAsync(Guid id);
    }
}
