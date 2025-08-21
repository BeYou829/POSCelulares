using Microsoft.EntityFrameworkCore;

namespace POSCelulares.Data.Contexts
{
    public class PosDbContext(DbContextOptions<PosDbContext> options)
        : DbContext(options)
    {
    }
}
