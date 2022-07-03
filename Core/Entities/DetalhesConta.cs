namespace Core.Entities
{
    public class DetalhesConta
    {
        public int Id { get; set; }
        public int NumeroNfe { get; set; }
        public int Parcelas { get; set; }
        public string Observacoes { get; set; }
        public byte Anexo { get; set; }
    }
}
