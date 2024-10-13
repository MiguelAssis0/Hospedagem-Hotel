using System.Text;
using SistemaHospedagemDeHotel.Models;

Console.OutputEncoding = Encoding.UTF8;
List<Pessoa> hospedes = new List<Pessoa>();
List<Pessoa> hospedes2 = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome:"Miguel", sobrenome:"Anjos");
Pessoa p2 = new Pessoa(nome:"Pedro", sobrenome:"Santos");
Pessoa p3 = new Pessoa(nome:"Maria", sobrenome:"Beatriz");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes2.Add(p3);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite suite2 = new Suite(tipoSuite: "Comum", capacidade: 1, valorDiaria: 10);

Reserva reserva = new Reserva(diasReservados: 10);
Reserva reserva2 = new Reserva(diasReservados: 2);

try
{
    reserva2.CadastrarSuite(suite2);
    reserva2.CadastrarHospedes(hospedes2);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    Console.WriteLine($"Tipo do quarto: {suite2.TipoSuite}");
    Console.WriteLine($"Quantidade de Hospedes: {reserva2.ObterQuantidadeHospedes()}");
    foreach (var item in hospedes2)
    {
        Console.WriteLine("Nome: " + item.NomeCompleto.ToString());
    }
    Console.WriteLine("Valor diária: " + reserva2.CalcularValorDiaria());


    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"Tipo do quarto: {suite.TipoSuite}");
    Console.WriteLine($"Quantidade de Pessoas: {reserva.ObterQuantidadeHospedes()}");
    foreach (var item in hospedes)
    {
        Console.WriteLine("Nome: " + item.NomeCompleto.ToString());
    }
    Console.WriteLine("Valor diária: " + reserva.CalcularValorDiaria());
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu o seguinte erro: " + e.Message);
}





