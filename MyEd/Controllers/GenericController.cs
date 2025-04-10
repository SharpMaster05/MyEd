using Microsoft.AspNetCore.Mvc;
using MyEd.BOL.Abstractions;

namespace MyEd.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenericController<T> : ControllerBase
    where T : class, new()
{
    private readonly IService<T> _service;

    public GenericController(IService<T> service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<T>>> GetAsync()
    {
        var items = await _service.GetAllAsync();

        return Ok(items);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<T>> GetByIdAsync(int id)
    {
        var item = await _service.GetByIdAsync(id);

        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<T>> PostAsync([FromBody] T dto)
    {
        await _service.AddAsync(dto);
        return Ok(dto);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<T>> PutAsync(int id, [FromBody] T dto)
    {
        var existingItem = await _service.GetByIdAsync(id);
        
        if (existingItem == null)
        {
            return NotFound($"Item with id {id} not found.");
        }

        dto.GetType().GetProperty("Id")?.SetValue(dto, id);

        await _service.EditAsync(dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<T>> DeleteAsync(int id)
    {
        var item = await _service.GetByIdAsync(id);

        if (item == null)
            return NotFound();

        await _service.DeleteAsync(item);
        return Ok("Delete success!");
    }
}
