using Inventario.Application.Contract;
using Inventario.Application.Core;
using Inventario.Application.Dtos.Producto;

namespace Inventario.Application.Service
{
    public class ProductoService : IProductoService
    {
        public async Task<ServiceResult> Guardar(ProductoSaveDto dto)
        {
            var result = new ServiceResult();

         
            result.Success = true;
            result.Message = "Producto validado y listo para guardar";

            return result;
        }

        public async Task<ServiceResult> ObtenerTodos()
        {
            return new ServiceResult { Success = true, Message = "Lista cargada" };
        }
    }
}