namespace Class_Polimorphism.Models.Inmuebles;

// Clase DosAmbientes que hereda de Departamento
public class DosAmbiente : Departamento
{
    public DosAmbiente() : base(2)
    {

    }

    public DosAmbiente(bool tieneJardin, bool tienePatio, int cantidadAmbientes) : base(tienePatio, cantidadAmbientes)
    {
        TieneJardin = tieneJardin;
    }

    public bool TieneJardin { get; set; }

    public override void SumarAmbientes()
    {
        CantidadAmbientes += 2;
    }
}