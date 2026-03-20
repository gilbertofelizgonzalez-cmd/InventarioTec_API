using InventarioTec_API; 
using Microsoft.AspNetCore.Mvc;

namespace InventarioTec_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoRepository _repository;

   
        public ProductosController(IProductoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> Get()
        {
            var productos = await _repository.GetAll();
            return Ok(productos);
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> Post(ProductoCreateDTO dto)
        {
            var producto = new Producto
            {
                Nombre = dto.Nombre,
                Marca = dto.Marca,
                Precio = dto.Precio,
                Stock = dto.Stock
            };

            await _repository.Add(producto);
            return Ok(producto);
        }
    }
}