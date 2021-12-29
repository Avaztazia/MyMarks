using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyMarks.Dal.Repositories;
using MyMarks.Shared.Dtos;
using MyMarks.ViewModels;

namespace MyMarks.Controllers;

[Controller]
[Route("marks")]
public class MarksController : Controller
{
    private readonly GroupRepository _groupRepository;
    private readonly StudentsRepository _studentsRepository;
    private readonly SubjectsRepository _subjectsRepository;
    private readonly IMapper _mapper;

    public MarksController(
        GroupRepository groupRepository,
        StudentsRepository studentsRepository,
        SubjectsRepository subjectsRepository,
        IMapper mapper)
    {
        _groupRepository = groupRepository;
        _studentsRepository = studentsRepository;
        _subjectsRepository = subjectsRepository;
        _mapper = mapper;
    }

    [Route("student/{studentId:guid}")]
    [HttpGet]
    public async Task<IActionResult> Student(Guid studentId)
    {
        var vm = new StudentMarksVm
        {
            Student = _mapper.Map<StudentDto>(await _studentsRepository.GetByIdAsync(studentId)),
            Subjects = _mapper.Map<List<SubjectDto>>(await _subjectsRepository.GetByStudentIdAsync(studentId))
        };
        return View(vm);
    }

    [Route("group/{groupName}")]
    [HttpGet]
    public async Task<IActionResult> Group([FromRoute] string groupName)
    {
        var vm = new GroupMarksVm
        {
            Group = _mapper.Map<GroupDto>(await _groupRepository.GetByName(groupName)),
            Subjects = _mapper.Map<List<SubjectDto>>(await _subjectsRepository.GetByGroupName(groupName))
        };
        return View(vm);
    }
    
    [Route("teacher/{groupName}")]
    [HttpGet]
    public async Task<IActionResult> Teacher([FromRoute] string groupName)
    {
        var vm = new TeacherMarksVm
        {
            Group = _mapper.Map<GroupDto>(await _groupRepository.GetByName(groupName)),
            Subjects = _mapper.Map<List<SubjectDto>>(await _subjectsRepository.GetByGroupName(groupName))
        };
        return View(vm);
    }
}