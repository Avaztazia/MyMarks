using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyMarks.Dal.Repositories;

namespace MyMarks.Dal;

public static class DalInstaller
{
    public static IServiceCollection AddDal(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<MyMarksDbContext>(x =>
            x.UseNpgsql(config["ConnectionStrings:MyMarksDb"]));

        services.AddTransient<GroupRepository, GroupRepository>();
        services.AddTransient<MarksRepository, MarksRepository>();
        services.AddTransient<PairsRepository, PairsRepository>();
        services.AddTransient<StudentsRepository, StudentsRepository>();
        services.AddTransient<TeachersRepository, TeachersRepository>();
        services.AddTransient<SubjectsRepository, SubjectsRepository>();

        return services;
    }
}