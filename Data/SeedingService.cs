using Agendamento.Models;

namespace Agendamento.Data
{
    public class SeedingService
    {
        private readonly AppDbContext _context;

        public SeedingService(AppDbContext context)
        {
            _context = context;
        }

        public void Popula()
        {
            if (_context.Medicos.Any())
            {
                return;
            }
            else
            {
                Medico m1 = new Medico
                {
                    Nome = "Luiza",
                    Crm = "123456",
                    Especialidade = "Vascular"
                };

                Medico m2 = new Medico
                {
                    Nome = "João",
                    Crm = "654321",
                    Especialidade = "Ortopedista"
                };

                _context.Medicos.AddRange(m1, m2);
                _context.SaveChanges();


            }
        }


    }
}
