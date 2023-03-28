namespace Resposta_4.Models
{
    public static class Fabrica
    {
        private const int _porcentagemLucro = 25;

        public static CarroEletrico FabricarCarroEletrico() => new();
        public static CarroDiesel FabricarCarroDiesel() => new();
        public static CarroFlex FabricarCarroFlex() => new();
        
        public static double ObterCustoVenda(Carro carro)
        {
            double valorImposto = carro.CustoProducao * (carro.PorcentagemImpostoProducao / 100);
            double valorLucro = carro.CustoProducao * (_porcentagemLucro / 100);
            return carro.CustoProducao + valorImposto + valorLucro;
        }
    }
}
