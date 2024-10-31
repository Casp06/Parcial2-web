using Microsoft.EntityFrameworkCore;
// Cristopher 2023-1193
public class VisitaContext: DbContext{
    public VisitaContext(DbContextOptions<VisitaContext> options) : base(options){}
    public DbSet<Visita> Visitas{ get; set; }
}