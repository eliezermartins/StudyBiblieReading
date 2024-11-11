using Microsoft.AspNetCore.Mvc;
using StudyBibleReading.App.Services;
using StudyBibleReading.Domain.Models;

namespace StudyBiblieReading.WebAPI.Controllers;

[ApiController]
[Route("api/publisher")]
public class PublisherController(PublisherService publisherService) : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(Publisher), StatusCodes.Status201Created)]
    public async Task<IActionResult> Create(Publisher publisher)
    {
        try
        {
            var result = await publisherService.Create(publisher);
            return CreatedAtAction(nameof(GetById), new { id = publisher.Id }, publisher);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(Publisher), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var result = await publisherService.GetById(id);
            return result is null ? NotFound() : Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpGet("all")]
    [ProducesResponseType(typeof(IEnumerable<Publisher>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await publisherService.GetAll();
            return result is null ? NotFound() : Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpPut]
    [ProducesResponseType(typeof(IEnumerable<Publisher>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Publisher publisher)
    {
        try
        {
            var publisherResult = await publisherService.GetById(publisher.Id);
            if (publisherResult is null)
            {
                return NotFound();
            }

            var result = await publisherService.Update(publisher);
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            var publisherResult = await publisherService.GetById(id);
            if (publisherResult is null)
            {
                return NotFound();
            }

            await publisherService.Delete(publisherResult);
            return Ok();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }
}
