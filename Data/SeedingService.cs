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

        public void PopulaPacientes()
        {
            if (_context.Paciente.Any())
            {
                return;
            }

            Paciente p1 = new Paciente
            {
                Nome = "Ana Silva",
                CPF = "11111111111",
                Telefone = "11999998888",
                Endereco = "Rua das Flores, 100",
                DataNascimento = new DateOnly(1995, 5, 20)
            };

            Paciente p2 = new Paciente
            {
                Nome = "Carlos Souza",
                CPF = "22222222222",
                Telefone = "21988887777",
                Endereco = "Avenida Brasil, 200",
                DataNascimento = new DateOnly(1988, 10, 15)
            };

            _context.Paciente.AddRange(p1, p2);
            _context.SaveChanges();
        }


    }
}
