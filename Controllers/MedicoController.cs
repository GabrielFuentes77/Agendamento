using Agendamento.Services;
using Microsoft.AspNetCore.Mvc;

namespace Agendamento.Controllers
{
    public class MedicoController : Controller
    {

        private readonly MedicoService _medicoService;

        public MedicoController(MedicoService medicicoService)
        {
            _medicoService = medicicoService;
        }


        public IActionResult Index()
        {
            var listaMedicos = _medicoService.Listar();
            return View(listaMedicos);
        }
    }
}
