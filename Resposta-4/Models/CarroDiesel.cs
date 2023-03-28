namespace Resposta_4.Models
{
    public class CarroDiesel : Carro
    {
        public int CapacidadeCarga { get; set; }
        public int VolumeCacamba { get; set; }

        public CarroDiesel()
        {
            PorcentagemImpostoProducao += 10;
        }
    }
}
