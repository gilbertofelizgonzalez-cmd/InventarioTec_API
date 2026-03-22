using Microsoft.AspNetCore.Mvc;
using Inventario.Application.Contract; 
using Inventario.Application.Dtos.Producto; 

namespace Inventario.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
      
        private readonly IProductoService _productoService;

        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
          
            var result = await _productoService.ObtenerTodos();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductoSaveDto dto)
        {
          
            var result = await _productoService.Guardar(dto);

            if (!result.Success)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}