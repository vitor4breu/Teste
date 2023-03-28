using Resposta_4.Models;

var carroEletrico = Fabrica.FabricarCarroEletrico();
carroEletrico.CustoProducao = 10000;

Console.Write(Fabrica.ObterCustoVenda(carroEletrico));
