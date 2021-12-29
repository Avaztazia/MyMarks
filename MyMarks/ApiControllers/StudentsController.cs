using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyMarks.Dal.Entities;
using MyMarks.Dal.Repositories;
using MyMarks.Shared.Dtos;

namespace MyMarks.ApiControllers;

[ApiController]
[Route("students")]
public class StudentsController : Controller
{
    private readonly StudentsRepository _studentsRepository;
    private readonly IMapper _mapper;
    
    public StudentsController(StudentsRepository studentsRepository, IMapper mapper)
    {
        _studentsRepository = studentsRepository;
        _mapper = mapper;
    }

    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] StudentDto student)
    {
        student.BirthDate = DateTimeOffset.UtcNow;

        await _studentsRepository.AddAsync(_mapper.Map<Student>(student));
        return Ok();
    }
}