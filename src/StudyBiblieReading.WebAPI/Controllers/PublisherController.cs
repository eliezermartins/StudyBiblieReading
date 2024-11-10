using Microsoft.AspNetCore.Mvc;
using StudyBibleReading.App.Services;
using StudyBibleReading.Domain.Models;

namespace StudyBiblieReading.WebAPI.Controllers;

[ApiController]
[Route("api/publisher")]
public class PublisherController(PublisherService publisherService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(Publisher publisher)
    {
        try
        {
            var result = await publisherService.Create(publisher);
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        try
        {
            var result = await publisherService.GetById(id);
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await publisherService.GetAll();
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update(Publisher publisher)
    {
        try
        {
            var result = await publisherService.Update(publisher);
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }
}
