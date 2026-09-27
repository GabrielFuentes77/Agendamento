using Agendamento.Services;
using Microsoft.AspNetCore.Mvc;

namespace Agendamento.Controllers
{
    public class PacienteController : Controller
    {

        private readonly PacienteService _pacienteService;

        public PacienteController(PacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        public IActionResult Index()
        {
            var ListaPacientes = _pacienteService.Listar();
            return View(ListaPacientes);
        }
    }
}
