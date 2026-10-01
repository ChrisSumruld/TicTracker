using Microsoft.EntityFrameworkCore;

public class TicTrackerContext(DbContextOptions<TicTrackerContext> options) : DbContext(options)
{
    public DbSet<TicTracker.Components.Models.QuoteEntry> QuoteEntry { get; set; } = default!;
}
