int[] vetor = new int[5];
int somaPar = 0;
int contaImpar = 0;
int input;

// Soma de dois valores
int soma(int valor1, int valor2)
{
    return valor1 + valor2;
};

// Iteracao para lancamento dos valores e somas
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($" Valor da Posição nº: {i + 1}");
    input = int.Parse(Console.ReadLine());

    vetor[i] = input;
    if (input % 2 == 0)
    {
        somaPar = soma(somaPar, input);
    }
    else
    {
        contaImpar += 1;
    }
};

Console.WriteLine($" SomaPar = {somaPar}, ContaImpar = {contaImpar}");

Console.WriteLine($" Vetor = ({vetor[0]},{vetor[1]},{vetor[2]},{ vetor[3]},{vetor[4]})");