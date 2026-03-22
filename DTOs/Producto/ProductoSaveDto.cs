using System.ComponentModel.DataAnnotations;

namespace Inventario.Application.Dtos.Producto
{
    public class ProductoSaveDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        [Range(0.1, 1000000, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La existencia es requerida")]
        [Range(0, 5000, ErrorMessage = "La existencia no puede ser negativa")]
        public int Existencia { get; set; }
    }
}