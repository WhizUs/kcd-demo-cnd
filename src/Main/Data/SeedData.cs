using Main.Models;
using Microsoft.EntityFrameworkCore;

namespace Main.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new ProjectsContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ProjectsContext>>());
        
        context.Database.Migrate();
        
        // Look for any movies.
        if (context.Project.Any())
        {
            return;   // DB has been seeded
        }
        context.Project.AddRange(
            new Project
            {
                Name = "Kubernetes",
                Link = "https://github.com/kubernetes/kubernetes",
                Stars = 101790
            },
            new Project
            {
                Name = "Argo",
                Link = "https://github.com/argoproj/argo-cd",
                Stars = 12791
            },
            new Project
            {
                Name = "Cilium",
                Link = "https://github.com/cilium/cilium",
                Stars = 15080
            },
            new Project
            {
                Name = "containerd",
                Link = "https://github.com/containerd/containerd",
                Stars = 13753
            },
            new Project
            {
                Name = "Prometheus",
                Link = "https://github.com/prometheus/prometheus",
                Stars = 47774
            },
            new Project
            {
                Name = "Helm",
                Link = "https://github.com/helm/helm",
                Stars = 24171
            },
            new Project
            {
                Name = "Vitess",
                Link = "https://github.com/vitessio/vitess",
                Stars = 15996
            },
            new Project
            {
                Name = "etcd",
                Link = "https://github.com/etcd-io/etcd",
                Stars = 43211
            },
            new Project
            {
                Name = "Open Policy Agent (OPA)",
                Link = "https://github.com/open-policy-agent/opa",
                Stars = 7935
            },
            new Project
            {
                Name = "Jaeger",
                Link = "https://github.com/jaegertracing/jaeger",
                Stars = 17481
            }
        );
        context.SaveChanges();
    }
}