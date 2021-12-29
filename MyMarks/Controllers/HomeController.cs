using System.Diagnostics;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyMarks.Dal.Repositories;
using MyMarks.Shared.Dtos;
using MyMarks.ViewModels;

namespace MyMarks.Controllers;

public class HomeController : Controller
{
    private readonly TeachersRepository _teachersRepository;
    private readonly GroupRepository _groupsRepository;
    private readonly IMapper _mapper;

    public HomeController(
        TeachersRepository teachersRepository,
        GroupRepository groupsRepository,
        IMapper mapper)
    {
        _teachersRepository = teachersRepository;
        _groupsRepository = groupsRepository;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        var teacherId = new Guid("6b7e6936-4c91-4766-b9c0-ea0258e9ad45");
        
        var vm = new IndexPageVm
        {
            Teacher = _mapper.Map<TeacherDto>(await _teachersRepository.GetByIdAsync(teacherId)),
            Groups = _mapper.Map<List<GroupDto>>(await _groupsRepository.GetGroupsForTeacher(teacherId)),
        };
        
        return View(vm);
    }
}