static int ContaParesEImparesERetornaMaiorOcorrencia(int[,] matriz, int numLinhas, int numColunas)
{
    int qntdPares = 0;
    int qntdImpares = 0;

    for (int i = 0; i < numLinhas; i++)
    {
        for (int j = 0; j < numColunas; j++)
        {
            if (matriz[i, j] % 2 == 0)
                qntdPares++;
            else
                qntdImpares++;

        }
    }

    return qntdPares > qntdImpares ? qntdPares:qntdImpares;
}
