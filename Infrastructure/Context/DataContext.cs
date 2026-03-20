using Microsoft.EntityFrameworkCore;

namespace InventarioTec_API;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Producto> Productos { get; set; }
}