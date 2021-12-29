using Microsoft.AspNetCore.Mvc;
using MyMarks.Dal.Repositories;
using MyMarks.Shared.Dtos;

namespace MyMarks.ApiControllers;

[ApiController]
[Route("pairs")]
public class PairsController : Controller
{
    private readonly PairsRepository _pairsRepository;

    public PairsController(PairsRepository pairsRepository)
    {
        _pairsRepository = pairsRepository;
    }

    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] PairDto pair)
    {
        pair.PairDateTime = DateTimeOffset.UtcNow;
        pair.Marks = new List<MarkDto>();

        await _pairsRepository.AddAsync(pair);
        return Ok();
    }
}