internal class Exercicio1
{
    //Escreva um programa que leia 15 valores reais, e informe o maior e o menor entre eles.
    private static void Main(string[] args)
    {
        double maior = 0;
        double menor = 0;

        Console.WriteLine("Digite 15 valores reais: ");
        double valor = double.Parse(Console.ReadLine());
        maior = valor;
        menor = valor;
        int cont = 0;

        for (cont = 0; cont < 14; cont++)
        {
            valor = double.Parse(Console.ReadLine());

            if (menor > valor)
            {
                menor = valor;
            }
            if (maior < valor)
            {
                maior = valor;
            }
        }
        Console.WriteLine("O maior é= " + maior);
        Console.WriteLine("O menor é= " + menor);
    }
}