double[] salarios = new double[5];
string? salario;

for (int i = 0; i<5; i++)
{
    Console.WriteLine("Digite o salario da pessoa " + (i+1) + ": ");
    salario = Console.ReadLine();
    Double.TryParse(salario, out salarios[i]);
    if (salarios[i] < 1000)
    {
        salarios[i] += salarios[i] * 0.1;
    }
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Salario da pessoa " + (i+1) + ": " + salarios[i]);
}
