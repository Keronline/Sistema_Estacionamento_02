using System.Globalization;

namespace Sistema_Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoPorHora = 0;
        private decimal precoInicial = 0;
        private List<Veiculo> Veiculos = new List<Veiculo>();
        private Dictionary<string, int> Porte = new Dictionary<string, int>()
        { 
            {"P", 5},
            {"M", 7},
            {"G", 10}
        
        };

        public Estacionamento()
        {
            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o valor por hora:");
            this.precoPorHora = Convert.ToDecimal(Console.ReadLine());
        }

        public void Adicionar()
        {
            string proprietario, placa, porte;

            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

            Console.WriteLine("Digite o nome do proprietário do veículo:");
            proprietario = Console.ReadLine();
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            Console.WriteLine("\nDigite o porte do veículo (P - Pequeno/M - Médio/G - Grande):");
            porte = Console.ReadLine();
            Console.Clear();

            Veiculo veiculo = new Veiculo(placa, proprietario, porte);
            Veiculos.Add(veiculo);
            Console.WriteLine($"\nConsiderando o porte do veículo que é {porte.ToUpper()}, o valor inicial é de {Porte[porte.ToUpper()]:C2} reais. Veículo registrado com sucesso!");
        }

        public void Remover()
        {
            Console.WriteLine("\nDigite a placa do veículo para remover:");
            var placa = Console.ReadLine();
            Veiculo? veiculo = Veiculos.FirstOrDefault(v => v.Placa.ToUpper() == placa.ToUpper(), null);
            
            if (veiculo != null)
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                Console.Clear();

                this.precoInicial = Porte[veiculo.Porte.ToUpper()];
                decimal valorTotal = horas * this.precoPorHora + this.precoInicial;

                Veiculos.Remove(veiculo);
                Console.WriteLine($"O veículo de {veiculo.Proprietario} e placa {placa} foi removido e o preço total foi de: {valorTotal:C2} reais.");
                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void Listar()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in Veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo.Placa} | Proprietário: {veiculo.Proprietario} | Porte: {veiculo.Porte.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}