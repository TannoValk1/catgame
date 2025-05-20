using catgame.Core.ServiceInterface;
using catgame.Data;
using catgame.Models.Cats;
using Microsoft.AspNetCore.Mvc;

namespace catgame.Controllers
{
    public class CatsController : Controller
    {
        private readonly catgameContext _context;
        private readonly ICatsServices _catsServices;
        public CatsController(catgameContext context, ICatsServices catsServices)
        {
            _context = context;
            _catsServices = catsServices;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var resultingInventory = _context.Cats
                .OrderByDescending(y => y.CatLevel)
                .Select(x => new CatIndexViewModel
                {
                    ID = x.ID,
                    CatName = x.CatName,
                    CatType = (CatType)x.CatType,
                    CatLevel = x.CatLevel,
                });
            return View(resultingInventory);
        }
    }
}
