using Microsoft.AspNetCore.Mvc;
using StudyBibleReading.App.Services;
using StudyBibleReading.Domain.Models;

namespace StudyBiblieReading.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TranslationsController(TranslationService translationService) : ControllerBase
{
    [HttpGet("all")]
    [ProducesResponseType(typeof(IEnumerable<Translation>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await translationService.GetAll();
            return result is null ? NotFound() : Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(Translation), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        try
        {
            var result = await translationService.GetById(id);
            return result is null ? NotFound() : Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpPut("{id}")]
    [ProducesResponseType(typeof(IEnumerable<Translation>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, Translation translation)
    {
        try
        {
            var publisherResult = await translationService.GetById(translation.Id);
            if (publisherResult is null)
            {
                return NotFound();
            }

            var result = await translationService.Update(translation);
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpPost]
    [ProducesResponseType(typeof(Translation), StatusCodes.Status201Created)]
    public async Task<IActionResult> Create(Translation translation)
    {
        try
        {
            var result = await translationService.Create(translation);
            return CreatedAtAction(nameof(GetById), new { id = translation.Id }, translation);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            var translationResult = await translationService.GetById(id);
            if (translationResult is null)
            {
                return NotFound();
            }

            await translationService.Delete(translationResult);
            return Ok();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }
}
