using GSM.Core.Domain.Games;
using GSM.Core.Repository.IGenericRepository;
using GSM.Data.Repository.GenericRepository;
using Microsoft.AspNetCore.Mvc;

namespace GSM.Api.Controllers
{
    [Route("api/games/")]
    public class GameController : Controller
    {
        private IGenericRepository<Game> _repository = null;

        public GameController(IGenericRepository<Game> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public JsonResult Index()
        {
            var model = _repository.GetAll();
            return Json(model);
        }

    }
}
