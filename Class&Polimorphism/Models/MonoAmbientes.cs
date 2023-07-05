namespace Class_Polimorphism.Models.Inmuebles
{
    public class MonoAmbiente : Departamento
    {
        public MonoAmbiente() : base(1)
        {

        }

        public MonoAmbiente(bool tieneJardin, bool tienePatio, int cantidadAmbientes) : base(tienePatio, cantidadAmbientes)
        {
            TieneJardin = tieneJardin;
        }

        public bool TieneJardin { get; set; }
                                                     
        public override void SumarAmbientes()
        {
            CantidadAmbientes += 1;
        }
    }
}