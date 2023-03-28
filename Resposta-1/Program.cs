while (true)
{
	Console.Write("Digite um número:");
	var stringPosicao = Console.ReadLine();


    if (!int.TryParse(stringPosicao, out int posicao))
    {
        Console.WriteLine("Erro: O valor digitado não é um número");
        continue;
    }

    double numeroPosZero = 0, numeroPosUm = 1, aux;

	if (posicao == 0) Console.WriteLine(numeroPosZero);
	else if (posicao == 1) Console.WriteLine(numeroPosUm);
	else {
		for (int i = 0; i​​​​​​​ < posicao; i++)
		{
			aux = numeroPosZero;
			numeroPosZero = numeroPosUm;
			numeroPosUm = numeroPosZero + aux;
		}
		Console.WriteLine($"O número na posição {posicao} é {numeroPosZero}");
	}
}
