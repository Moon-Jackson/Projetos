using System;

class JogoDeAdivnhação
{
    static void Main(string[] args)
    {
        Random numeroAleatorio = new Random(); //Gerar numeros aleatorios.
        int NumeroSecreto = numeroAleatorio.Next(1, 100);//Com " int " a var "Random numeroAleatorio" ira gerar numeros aleatorios de valor inteiro.
        int tentativa; //Vai armazenar o valor digitado pelo user.
        int tentativas = 0; //Vai guardar os tentativas feitas pelo user.

        Console.WriteLine("=== Jogo de Adivinhação ===");
        Console.WriteLine("Tente adivinhar o número de 1 a 100!");


        //O "while" ira continuar repetindo o processo enquanto valor digitado do usuario for diferente do numero aleatório gerado pelo programa.
        do
        {
            Console.WriteLine("Digite um numero");
            tentativa = int.Parse(Console.ReadLine()); //A função int.Parse converte uma string em um número inteiro (int).
            tentativas++;

            if (tentativa > NumeroSecreto)
            {
                Console.WriteLine("O numero é menor!");

            }
            else if (tentativa < NumeroSecreto)
            {
                Console.WriteLine("O número é maior");
            }
            else
            {
                Console.WriteLine($"Parabens você acertou o numero em {tentativas} tentativas.");
            }
        } while (tentativa != NumeroSecreto);

        Console.WriteLine("Fim de Jogo.");
    }
}