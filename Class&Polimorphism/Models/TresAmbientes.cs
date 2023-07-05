namespace Class_Polimorphism.Models.Inmuebles;
// Clase TresAmbientes que hereda de Departamento
public class TresAmbiente : Departamento
{
    public TresAmbiente() : base(3)
    {

    }

    public TresAmbiente(bool tieneJardin, bool tienePatio, int cantidadAmbientes) : base(tienePatio, cantidadAmbientes)
    {
        TieneJardin = tieneJardin;
    }

    public bool TieneJardin { get; set; }

    public override void SumarAmbientes()
    {
        CantidadAmbientes += 3;
    }
}
