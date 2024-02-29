Double[] vetor =  new double[5];
string? valor;
double soma = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o valor " + i + ": ");
    valor = Console.ReadLine();
    Double.TryParse(valor, out vetor[i]);
    soma += vetor[i];
}

Console.WriteLine("Media aritmética: "+ (soma / 5));