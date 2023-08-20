namespace VintageShop.Entidades
{
    public class Zapato
    {
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public string Imagen { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual List<Talle> Talles { get; set; } = new List<Talle>();

        public virtual List<Pago> PagosList { get; set; } //no entiendo porque

        public virtual List<Stock> StocksList { get; set; }

    }
}