
double[] vet = new double[10];
string? valor;
double salario;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o salário da pessoa " + (i + 1) + ": ");
    valor = Console.ReadLine();
    Double.TryParse(valor, out salario);
    vet[i] = salario;
}

double maiorSalario = 0;
for(int i = 0; i < 10; i++){
    if (vet[i] > maiorSalario)
    {
        maiorSalario = vet[i];
    }
}

Console.WriteLine("Maior salário: R$"+ maiorSalario);
