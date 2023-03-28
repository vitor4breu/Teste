namespace Resposta_4.Models
{
    public abstract class Carro
    {
        public int NumeroChassi { get; set; }
        public int NumeroMotor { get; set; }
        public double CustoProducao { get; set; }
        public double PorcentagemImpostoProducao { get; protected set; } = 20;
    }
}
