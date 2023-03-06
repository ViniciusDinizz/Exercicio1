using System;


double[] numeros = new double[15];
int opcao = 0;

int menu()
{
    opcao = 0;
    Console.Clear();
    Console.WriteLine("1 - Inserir números e encontrar maior e menor.");
    Console.WriteLine("2 - Sair.");

    int.TryParse(Console.ReadLine(), out opcao);
    if (opcao == 0)
        int.TryParse(Console.ReadLine(), out opcao);

    return opcao;
}
void inserirnum()
{
    int contador = 0;
    Console.Clear();
    do
    {
        Console.Write($"Informe o {contador + 1} número: ");
        double.TryParse(Console.ReadLine(), out numeros[contador]);
        contador++;
    } while (contador < 15);
    Console.Clear();
}

void acharmaior()
{
    double maior = 0;
    maior = numeros[0];
    for (int i = 0; i < 15 ; i++)
    {
        if (maior < numeros[i])
        {
            maior = numeros[i];
        }
    }
    Console.WriteLine($"Maior número: {maior}");
}

void acharmenor()
{
    double menor = 0;
    menor = numeros[0];
    for (int i =0; i < 15; i++)
    {
        if (menor > numeros[i])
        {
            menor = numeros[i];
        }
    }
    Console.WriteLine($"Menor número: {menor}");
}


do {
    menu();
    switch (opcao)
    {
        case 1:
            inserirnum();
            acharmaior();
            acharmenor();
            Console.Write("Press enter...");
            Console.Read();
            break;

        case 2:
            Console.WriteLine("Até logo.");
            break;
        default:
            Console.Write("Opcao invalida. Insira outra...");
            Console.ReadLine();
            break;

    }
}while(opcao != 2);

