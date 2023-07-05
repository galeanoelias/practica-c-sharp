namespace Class_Polimorphism.Models.Inmuebles
{
    public class Casa : Departamento
    {
        public Casa() : base(1)
        {

        }

        public Casa(int cantidadArbol, bool tienePatio, int cantidadAmbientes) : base(tienePatio, cantidadAmbientes)
        {
            CantidadArbol = cantidadArbol;
        }

        public int CantidadArbol { get; set; }

        public override void SumarAmbientes()
        {
            CantidadAmbientes += 1;
        }
    }
}
