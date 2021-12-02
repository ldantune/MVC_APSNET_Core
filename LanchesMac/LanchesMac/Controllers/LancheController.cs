using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ICategoriaRepository categoriaRepository, ILancheRepository lancheRepository)
        {
            _categoriaRepository = categoriaRepository;
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }

    }
}
