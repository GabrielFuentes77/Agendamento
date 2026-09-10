using Agendamento.Data;
using Agendamento.Models;

namespace Agendamento.Services
{
    public class MedicoService
    {
        private readonly AppDbContext _context;

        public MedicoService (AppDbContext context)
        {
            _context = context;
        }

        public List<Medico> Listar()
        {
            return _context.Medicos.ToList();
        }

    }
}
