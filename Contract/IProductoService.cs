using Inventario.Application.Core;
using Inventario.Application.Dtos.Producto;

namespace Inventario.Application.Contract
{
    public interface IProductoService
    {
        Task<ServiceResult> Guardar(ProductoSaveDto dto);

        Task<ServiceResult> ObtenerTodos();
    }
}