namespace Elevadores
{
    public abstract class Elevador
    {
        public int AndarAtual { get; set; } = 0;
        public int TotalAndares { get; protected set; }
        public float CapacidadePeso { get; protected set; }
        public int PessoasPresentes { get; set; }

    }
}