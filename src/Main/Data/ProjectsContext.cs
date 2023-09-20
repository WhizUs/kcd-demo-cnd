using Main.Models;
using Microsoft.EntityFrameworkCore;

namespace Main.Data;

public class ProjectsContext : DbContext
{
    public ProjectsContext (DbContextOptions<ProjectsContext> options)
        : base(options)
    {
    }

    public DbSet<Project> Project { get; set; } = default!;
}