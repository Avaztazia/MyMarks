using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyMarks.Dal.Entities;
using MyMarks.Dal.Repositories;
using MyMarks.Models;
using MyMarks.Shared.Dtos;

namespace MyMarks.ApiControllers;

[ApiController]
[Route("marks")]
public class MarksController : Controller
{
    private readonly MarksRepository _marksRepository;
    private readonly IMapper _mapper;

    public MarksController(
        MarksRepository marksRepository,
        IMapper mapper)
    {
        _marksRepository = marksRepository;
        _mapper = mapper;
    }

    [Route("save")]
    [HttpPost]
    public async Task<IActionResult> Save([FromBody] SaveMarkModel markModel)
    {
        markModel.EnsureValid();
        var markEnt = await _marksRepository.GetMarkForStudentByPairId(markModel.PairId, markModel.StudentId);

        if (markEnt != default)
        {
            markEnt.Grade = markModel.Grade;
            await _marksRepository.UpdateAsync(markEnt);
            return Ok();
        }

        var markDto = new MarkDto
        {
            Grade = markModel.Grade,
            StudentId = markModel.StudentId,
            TeacherId = markModel.TeacherId,
            PairId = markModel.PairId
        };

        await _marksRepository.AddAsync(_mapper.Map<Mark>(markDto));
        return Ok();
    }
}