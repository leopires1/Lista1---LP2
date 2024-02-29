using System.Runtime.Serialization;
using System.Xml;

int tam = 0;
string? valor;

Console.WriteLine("Qual o número de alunos que irão ser cadastrador? ");
valor = Console.ReadLine();
Int32.TryParse(valor, out tam);

double[] alunosG1 = new double[tam];
double[] alunosG2 = new double[tam];

for (int i = 0; i < tam; i++)
{
    Console.WriteLine("Digite a nota G1 do aluno " + (i+1) + ": ");
    valor= Console.ReadLine();
    Double.TryParse(valor, out alunosG1[i]);
}
for (int i = 0; i < tam; i++)
{
    Console.WriteLine("Digite a nota G2 do aluno " + (i + 1) + ": ");
    valor = Console.ReadLine();
    Double.TryParse(valor, out alunosG2[i]);
}
for (int i = 0; i < tam; i++)
{
    Console.WriteLine("Nota G1 do aluno " +(i+1)+ ": " + alunosG1[i]);
    Console.WriteLine("Nota G2 do aluno " + (i + 1) + ": " + alunosG2[i]);
    Console.WriteLine("Media das notas do aluno " +(i+1) + ": " + ((alunosG1[i] + alunosG2[i])/2));
}