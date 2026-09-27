namespace Agendamento.Helpers
{
    public static class Formatador
    {
        public static string FormatarCPF(string? cpf)
        {
            var numeros = new string(
                (cpf ?? "").Where(char.IsDigit).ToArray()
            );

            if (numeros.Length != 11)
                return cpf ?? "";

            return $"{numeros[..3]}.{numeros[3..6]}.{numeros[6..9]}-{numeros[9..]}";
        }

        public static string FormatarTelefone(string? telefone)
        {
            var numeros = new string(
                (telefone ?? "").Where(char.IsDigit).ToArray()
            );

            return numeros.Length switch
            {
                11 => $"({numeros[..2]}) {numeros[2..7]}-{numeros[7..]}",
                10 => $"({numeros[..2]}) {numeros[2..6]}-{numeros[6..]}",
                _ => telefone ?? ""
            };
        }
    }
}