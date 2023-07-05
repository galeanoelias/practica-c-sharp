namespace Class_Polimorphism.Models.Inmuebles
{
    // Clase abstracta de Inmueble
    public abstract class Inmueble
    {
        public string Direccion { get; set; }
        public int Precio { get; set; }
        public int Area { get; set; }

        public bool EstaEnVenta { get; set; }

        public void EnVenta()
        {
            EstaEnVenta = true;
        }

        public void Vendido()
        {
            EstaEnVenta = false;
        }
    }
}