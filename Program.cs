
    
        Console.Write("Digite o capital inicial (C): ");
        double capital = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de juros (I) em %: ");
        double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Digite o tempo (T): ");
        double tempo = Convert.ToDouble(Console.ReadLine());

        double juros = capital * taxa * tempo;

    
        double montante = capital + juros;

        Console.WriteLine($"\nJuros acumulado: R$ {juros:F2}");
        Console.WriteLine($"Montante final: R$ {montante:F2}");
    

