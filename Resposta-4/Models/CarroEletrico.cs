namespace Resposta_4.Models
{
    public class CarroEletrico : Carro
    {
        public int DuracaoBateria { get; set; }
        public int Potencia { get; set; }

        public CarroEletrico()
        {
            PorcentagemImpostoProducao -= 10;
        }
    }
}
