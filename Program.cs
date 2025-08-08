using Hospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>
{
    new Pessoa { Nome = "Jaqueline", Sobrenome = "Silva" },
    new Pessoa { Nome = "Carlos", Sobrenome = "Souza" }
};

Suite suite = new Suite
{
    TipoSuite = "Premium",
    Capacidade = 2,
    ValorDiaria = 120
};

Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {string.Join(", ", reserva.Hospedes.Select(h => h.NomeCompleto))}");
Console.WriteLine($"Suíte: {reserva.Suite.TipoSuite}");
Console.WriteLine($"Total de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da hospedagem: R$ {reserva.CalcularValorDiaria()}");
