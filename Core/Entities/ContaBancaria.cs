using Core.Entities.Enums;

namespace Core.Entities
{
    public class ContaBancaria
    {
        public string Instituicao { get; set; }
        public int Agencia { get; set; }
        public int Cc { get; set; }
        public PfPj Tipo { get; set; }

    }
}
