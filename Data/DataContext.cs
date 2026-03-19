using Microsoft.EntityFrameworkCore;
using InventarioTec_API.Models;

namespace InventarioTec_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}