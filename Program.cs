using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Console.WriteLine("Insira a Capacidade da Suite que deseja:");

int CapacidadeSuite = int.Parse(Console.ReadLine());

Console.WriteLine("Insira quantidade de dias que deseja reservar:");

int DiasResevardSuite = int.Parse(Console.ReadLine());

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: CapacidadeSuite, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: DiasResevardSuite);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");