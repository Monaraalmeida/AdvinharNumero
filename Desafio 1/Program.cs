//escolha um numero entre 1 e 100.

int numeroSorteado = 45;
    void advinharNumero()
    {
    Console.WriteLine("Escolha um número entre 1 e 100.");
    Console.Write("\nAgora digite-o: ");
    }

    advinharNumero();

do
{
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);



    if (opcaoEscolhidaNumero == numeroSorteado)
    {
        Console.WriteLine("Você acertou PARABÉNSSS!");
        break;
    }
    else if (opcaoEscolhidaNumero > 100)
    {
        Console.WriteLine("O número escolhido é maior do numero sorteado.\nDigite outro palpite: ");
    }
    else
    {
        Console.WriteLine("O número escolhido é menor do numero sorteado.\nDigite outro palpite: ");
    }
}
while (true);

   










