using Sistemas;  // Importe o namespace da classe Sistemas
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        char opcao;

        do
        {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("a) Fazer reserva da poltrona");
            Console.WriteLine("b) Listar lugares ocupados");
            Console.WriteLine("c) Listar lugares livres");
            Console.WriteLine("d) Mostrar percentual de ocupação");
            Console.WriteLine("e) Sair");
            Console.WriteLine("\nOpção:");
            opcao = Console.ReadLine()[0];

            switch (opcao)
            {
                case 'a':
                    Console.WriteLine("Fazer Reserva");
                    Sistemas.Sistemas.FazerReserva();  // Chama o método FazerReserva da classe Sistemas
                    break;

                case 'b':
                    Console.WriteLine("Listar lugares ocupados");
                    Sistemas.Sistemas.ListarLugaresOcupados();  // Chama o método ListarLugaresOcupados
                    break;

                case 'c':
                    Console.WriteLine("Listar lugares disponíveis");
                    Sistemas.Sistemas.ListarLugaresLivres();  // Chama o método ListarLugaresLivres
                    break;

                case 'd':
                    Console.WriteLine("Mostrar percentual de ocupação");
                    Sistemas.Sistemas.MostrarPercentualOcupacao();  // Chama o método MostrarPercentualOcupacao
                    break;

                case 'e':
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        } while (opcao != 'e');
    }
}
