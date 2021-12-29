using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using MyMarks;
using MyMarks.Dal;
using MyMarks.Dal.Entities;
using MyMarks.Shared.Dtos;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration.AddJsonFile("appsettings.json", false).Build();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDal(config);

builder.Services.AddAutoMapper(opt =>
{
    opt.CreateMap<Group, GroupDto>().ReverseMap();
    opt.CreateMap<Mark, MarkDto>().ReverseMap();
    opt.CreateMap<Pair, PairDto>().ReverseMap();
    opt.CreateMap<Student, StudentDto>().ReverseMap();
    opt.CreateMap<Subject, SubjectDto>().ReverseMap();
    opt.CreateMap<Teacher, TeacherDto>().ReverseMap();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();