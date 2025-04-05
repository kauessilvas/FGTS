Console.Clear();
double salary, fgts;
Console.WriteLine("============= Calcular FGTS =============");
while (true)
{
    Console.Write("Salário (R$)..: ");
    string input = Console.ReadLine()!;

    if (double.TryParse(input, out salary))
    {
        break;
    }
    else
    {
        Console.WriteLine("Valor inválido! Por favor, digite um número.");
    }
}

fgts = salary / 100 * 8;
Console.WriteLine($"FGTS: {fgts:C2}");
Console.WriteLine("=========================================");
