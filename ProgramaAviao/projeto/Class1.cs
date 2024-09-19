using System;

namespace Sistemas
{
    public class Sistemas
    {
        private static int NUMERO_DE_LUGARES = 12;
        private static bool[] lugaresOcupados = new bool[NUMERO_DE_LUGARES];

        public static void FazerReserva()
        {
            Console.WriteLine($"Informe o número da poltrona que deseja reservar\n(De 1 a {NUMERO_DE_LUGARES}):\n");
            int numeroPoltrona = int.Parse(Console.ReadLine());

            if (numeroPoltrona < 1 || numeroPoltrona > NUMERO_DE_LUGARES)
            {
                Console.WriteLine("Número de poltrona inválido!\n");
                return;
            }
            else if (lugaresOcupados[numeroPoltrona - 1])
            {
                Console.WriteLine("Esta poltrona já está ocupada\n");
            }
            else
            {
                lugaresOcupados[numeroPoltrona - 1] = true;
                Console.WriteLine($"Poltrona {numeroPoltrona} reservada com sucesso!\n");
            }
        }

        public static void ListarLugaresOcupados()
        {
            Console.WriteLine("Lugares ocupados:");
            for (int i = 0; i < NUMERO_DE_LUGARES; i++)
            {
                if (lugaresOcupados[i])
                {
                    Console.WriteLine($"Poltrona {i + 1}\n");
                }
            }
        }

        public static void ListarLugaresLivres()
        {
            Console.WriteLine("Lugares livres:");
            for (int i = 0; i < NUMERO_DE_LUGARES; i++)
            {
                if (!lugaresOcupados[i])
                {
                    Console.WriteLine($"Poltrona {i + 1}\n");
                }
            }
        }

        public static void MostrarPercentualOcupacao()
        {
            int lugaresOcupadosCount = 0;
            foreach (bool ocupado in lugaresOcupados)
            {
                if (ocupado)
                {
                    lugaresOcupadosCount++;
                }
            }

            double percentualOcupacao = (double)lugaresOcupadosCount / NUMERO_DE_LUGARES * 100;
            Console.WriteLine($"Percentual de ocupação: {percentualOcupacao:F2}%\n");
        }
    }
}
