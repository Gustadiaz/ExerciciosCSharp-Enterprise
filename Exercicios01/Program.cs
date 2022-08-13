// Exercício 01

/*Console.Write("Digite o valor A: ");
double valorA = double.Parse(Console.ReadLine());
Console.Write("Digite o valor B: ");
double valorB = double.Parse(Console.ReadLine());
Console.Write("Digite o valor C: ");
double valorC = double.Parse(Console.ReadLine());

// Letra A
double area = (valorA * valorC) / 2;
Console.WriteLine($"O valor da área do triângulo é: {area.ToString("F2")}");

// Letra B
double pi = 3.14159;
double area2 = pi * (valorC * valorC);
Console.WriteLine($"O valor da área do círculo de raio C é: {area2.ToString("F2")}");

// Letra C
double area3 = ((valorA + valorB) * valorC) / 2;
Console.WriteLine($"O valor da área do trapézio é: {area3.ToString("F2")}");

//Letra D
double area4 = valorB * valorB;
Console.WriteLine($"O valor da área do quadrado é: {area4.ToString("F2")}");

//Letra E
double area5 = valorA * valorB;
Console.WriteLine($"O valor da área do retângulo é: {area5.ToString("F2")}");*/

//Exercício 02
/*Console.Write("Digite o primeiro valor: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int B = int.Parse(Console.ReadLine());

if (A % B == 0 || B % A == 0)
{
    Console.WriteLine("São Múltiplos");
}
else
{
    Console.WriteLine("Não são Múltiplos");
}*/

//Exercício 03
/*Console.Write("Digite a Hora mais Otimista: ");
int otimista = int.Parse(Console.ReadLine());
Console.Write("Digite a Hora mais Pessimista: ");
int pessimista = int.Parse(Console.ReadLine());
Console.Write("Digite a Digite a Hora mais Provavel: ");
int provavel = int.Parse(Console.ReadLine());

double pert = (otimista + pessimista + (4 * provavel)) / 6;
Console.WriteLine($"Otimista: {otimista}");
Console.WriteLine($"Pessimista: {pessimista}");
Console.WriteLine($"Provavel: {provavel}");
Console.WriteLine($"PERT= {pert.ToString("F2")}");*/

// Exercicio 04
/*Console.Write("Digite a nota do aluno: ");
double nota = int.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (nota < 7 && nota >= 4)
{
    Console.WriteLine("Em Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}*/

//Exercício 05
/*Console.Write("Informe um número de 1 a 3: ");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Bom dia");
        break;
    case 2:
        Console.WriteLine("Boa tarde");
        break;
    case 3:
        Console.WriteLine("Boa noite");
        break;
    default:
        Console.WriteLine("Opção Inválida");
        break;
}*/

// Exercício 06
/*Console.Write("Calcule o fatorial: ");
int N = int.Parse(Console.ReadLine());
int fat = 1;

for (int i = 1; i <= N; i++)
{
    fat *= i;
}
Console.WriteLine($"N = {fat}");*/

// Exercício 07
/*Console.WriteLine("Digite valor de N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int primeiro = i;
    int segundo = i * i;
    int terceiro = i * i * i;
    Console.WriteLine($"{primeiro} {segundo} {terceiro}");
}*/

// Exercício 08
int tipo = 0;

int candidatoChaves = 0;
int candidatoChiquinha = 0;
int candidatoQuico = 0;
int votosNulo = 0;
int votosBranco = 0;

do
{
    Console.WriteLine("As opções são: ");
    Console.WriteLine();
    Console.WriteLine("1. Candidato Chaves");
    Console.WriteLine("2. Candidata Chiquinha");
    Console.WriteLine("3. Candidato Quico");
    Console.WriteLine("4. Nulo");
    Console.WriteLine("5. Branco");
    Console.WriteLine("6. Encerrar a Votação");
    Console.Write("Entre com o seu voto: ");

    tipo = int.Parse(Console.ReadLine());
    switch (tipo)
    {
        case 1:
            candidatoChaves++;
            break;
        case 2:
            candidatoChiquinha++;
            break;
        case 3:
            candidatoQuico++;
            break;
        case 4:
            votosNulo++;
            break;
        case 5:
            votosBranco++;
            break;
        case 6:
            Console.WriteLine("----------------------------");
            Console.WriteLine("Número de votos de cada candidato: ");
            Console.WriteLine("Candidato Chaves: " + candidatoChaves);
            Console.WriteLine("Candidata Chiquinha: " + candidatoChiquinha);
            Console.WriteLine("Candidato Quico: " + candidatoQuico);
            Console.WriteLine("Votos Nulo: " + votosNulo);
            Console.WriteLine("Votos Branco: " + votosBranco);

            int votosTotal = candidatoChaves + candidatoChiquinha + candidatoQuico + votosNulo + votosBranco;

            double percNulo = (votosNulo * 100) / votosTotal;
            double percBranco = (votosBranco * 100) / votosTotal;

            Console.WriteLine("Porcentagem de votos em Nulo: " + percNulo + "%");
            Console.WriteLine("Porcentagem de votos em Branco: " + percBranco + "%");

            if (candidatoChaves > candidatoChiquinha && candidatoChaves > candidatoQuico)
            {
                Console.WriteLine("O candidato vencedor foi o Candidato Chaves!");
            }

            else if (candidatoChiquinha > candidatoChaves && candidatoChiquinha > candidatoQuico)
            {
                Console.WriteLine("A candidata vencedora foi a Candidata Chiquinha!");
            }

            else if (candidatoQuico > candidatoChiquinha && candidatoQuico > candidatoChaves)
            {
                Console.WriteLine("O candidato vencedor foi o Candidato Quico!");
            }

            break;
        default:
            Console.WriteLine("Opção inválida, selecione um novo código");
            break;
    }
} while (tipo != 6);
