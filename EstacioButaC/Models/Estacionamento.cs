using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstacioButaC.Models
{
    internal class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public decimal CalcularPrecoEstacionamento(decimal precoInicial, decimal precoPorHora)
        {
            Console.WriteLine("Digite o tempo em horas que o veículo ficou estacionado:");
            int horasEstacionado = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = precoInicial + (precoPorHora * horasEstacionado);
            return valorTotal;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaDigitado = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placaDigitado.ToUpper()))
            {
                Console.WriteLine("Veículo já está estacionado");
            }
            else
            {   Console.WriteLine($"Veículo da {placaDigitado} cadastrado com sucesso!");
                veiculos.Add(placaDigitado);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaDigitado = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placaDigitado.ToUpper()))
            {
                decimal valorTotal = CalcularPrecoEstacionamento(precoInicial, precoPorHora);
                Console.WriteLine($"Veículo {placaDigitado} removido com sucesso! Valor total pago R$ {valorTotal}");
                veiculos.Remove(placaDigitado);
            }
            else
            {
                Console.WriteLine("Placa não existe");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count != 0 )
            {
                Console.WriteLine("Veículos estacionados:");    
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"Placa - {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo encontrado");
            }
        }
    }
}
