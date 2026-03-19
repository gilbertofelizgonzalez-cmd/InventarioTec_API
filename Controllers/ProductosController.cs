using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventarioTec_API.Data;
using InventarioTec_API.Models;
using InventarioTec_API.DTOs;

namespace InventarioTec_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> Get()
        {
            return await _context.Productos.ToListAsync();
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

            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return Ok(await _context.Productos.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Producto producto)
        {
            var item = await _context.Productos.FindAsync(id);
            if (item == null) return NotFound();

            item.Nombre = producto.Nombre;
            item.Marca = producto.Marca;
            item.Precio = producto.Precio;
            item.Stock = producto.Stock;

            await _context.SaveChangesAsync();
            return Ok(await _context.Productos.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Productos.FindAsync(id);
            if (item == null) return NotFound();

            _context.Productos.Remove(item);
            await _context.SaveChangesAsync();

            return Ok(await _context.Productos.ToListAsync());
        }
    }
}