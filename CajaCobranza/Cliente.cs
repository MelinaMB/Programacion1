
namespace CajaCobranzaColas
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - {Cantidad} productos - ${Importe}";
        }
    }
}
