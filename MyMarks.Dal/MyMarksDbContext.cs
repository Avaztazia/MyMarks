using Microsoft.EntityFrameworkCore;
using MyMarks.Dal.Entities;

namespace MyMarks.Dal;

public class MyMarksDbContext : DbContext
{
    public MyMarksDbContext(DbContextOptions options) : base(options)
    {
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=devPass$;Database=MyMarks");
    // }

    public DbSet<Group?> Groups { get; set; }
    public DbSet<Mark> Marks { get; set; }
    public DbSet<Pair> Pairs { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}