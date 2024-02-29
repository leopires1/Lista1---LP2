int[] vet1 = new int[5];
int[] vet2 = new int[5];
string? valor = "";

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o valor " + (i + 1) + " do vetor 1: ");
    valor = Console.ReadLine();
    Int32.TryParse(valor, out vet1[i]);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o valor " + (i + 1) + " do vetor 2: ");
    valor = Console.ReadLine();
    Int32.TryParse(valor, out vet2[i]);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Soma das posições " + (i + 1) + " dos vetores: " + vet1[i] + " + " + vet2[i] + " = " + (vet1[i] + vet2[i]));
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Subtração das posições " + (i + 1) + " dos vetores: " + vet1[i] + " - " + vet2[i] + " = " + (vet1[i] - vet2[i]));
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Multiplicação das posições " + (i + 1) + " dos vetores: " + vet1[i] + " * " + vet2[i] + " = " +(vet1[i] * vet2[i]));
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Divisão das posições " + (i + 1) + " dos vetores: " + vet1[i] + " + " + vet2[i] + " = " + (vet1[i] / vet2[i]));
}

