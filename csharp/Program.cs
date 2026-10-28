using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // --- 4 TIMES INICIAIS ---
        List<string> times = new List<string> { "Atlético-MG", "Cruzeiro", "América-MG", "Villa Nova" };

        // Exibir os times com seus índices
        Console.WriteLine("=== Times Cadastrados ===");
        for (int i = 0; i < times.Count; i++)
        {
            Console.WriteLine($"{i} - {times[i]}");
        }

        // Jogos de ida e volta
        Console.WriteLine("\n=== Jogos de Ida e Volta (4 Times) ===");
        int totalIdaVolta = 0;
        for (int i = 0; i < times.Count; i++)
        {
            for (int j = 0; j < times.Count; j++)
            {
                if (i != j)
                {
                    Console.WriteLine($"{times[i]} x {times[j]}");
                    totalIdaVolta++;
                }
            }
        }
        Console.WriteLine($"Total de jogos de ida e volta: {totalIdaVolta}");

        // Turno único
        Console.WriteLine("\n=== Turno Único (4 Times) ===");
        int totalTurnoUnico = 0;
        for (int i = 0; i < times.Count; i++)
        {
            for (int j = i + 1; j < times.Count; j++)
            {
                Console.WriteLine($"{times[i]} x {times[j]}");
                totalTurnoUnico++;
            }
        }
        Console.WriteLine($"Total de jogos em turno único: {totalTurnoUnico}");

        // --- ALTERAÇÃO DA COLEÇÃO (INCLUIR TOMBENSE) ---
        Console.WriteLine("\n=== Adicionando Tombense no C# ===");
        times.Add("Tombense");

        Console.WriteLine("\n--- Tabela Recalculada com 5 Times (Ida e Volta) ---");
        totalIdaVolta = 0;
        for (int i = 0; i < times.Count; i++)
        {
            for (int j = 0; j < times.Count; j++)
            {
                if (i != j)
                {
                    Console.WriteLine($"{times[i]} x {times[j]}");
                    totalIdaVolta++;
                }
            }
        }
        Console.WriteLine($"Total de jogos de ida e volta (5 times): {totalIdaVolta}");

        Console.WriteLine("\n--- Tabela Recalculada com 5 Times (Turno Único) ---");
        totalTurnoUnico = 0;
        for (int i = 0; i < times.Count; i++)
        {
            for (int j = i + 1; j < times.Count; j++)
            {
                Console.WriteLine($"{times[i]} x {times[j]}");
                totalTurnoUnico++;
            }
        }
        Console.WriteLine($"Total de jogos em turno único (5 times): {totalTurnoUnico}");
    }
}
