using Sistema_Estacionamento.Models;
using System;

namespace Sistema_Estacionamento
{
    class Program
    {
        public static void Main(string[] args)
        {
            var estacionamento = new Estacionamento();
            char opcao = ' ';

            while(opcao != '4')
            {
                Menu();
                opcao = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case '1':
                        estacionamento.Adicionar();
                        break;
                    case '2':
                        estacionamento.Remover();
                        break;
                    case '3':
                        estacionamento.Listar();
                        break;
                    case '4':
                        opcao = '4';
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("O programa se encerrou");
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
        }
    }
}