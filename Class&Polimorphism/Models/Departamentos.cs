namespace Class_Polimorphism.Models.Inmuebles
{
    public abstract class Departamento : Inmueble
    {
        public Departamento(int cantidadAmbienteInicial)
        {
            CantidadAmbientes = cantidadAmbienteInicial;
        }

        public Departamento(bool tienePatio, int cantidadAmbienteInicial) 
        {
            TienePatio = tienePatio;
            CantidadAmbientes = cantidadAmbienteInicial;
        }

        public bool TienePatio { get; set; }

        public int CantidadAmbientes { get; set; }

        //public abstract int SumarVentanas(int cantidad);
        public abstract void SumarAmbientes();
    }
}