namespace InventarioTec_API;

public class ProductoCreateDTO
{
    public string Nombre { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public double Precio { get; set; }
    public int Stock { get; set; }
}