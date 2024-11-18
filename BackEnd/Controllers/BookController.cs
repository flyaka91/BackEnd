using BackEnd.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("api/user")]
public class BookController : ControllerBase
{
    [HttpPost]
    public ActionResult<Guid> AddBook([FromBody] AddBookRequest request)
    {
        var addedBookId = Guid.NewGuid();
        return Ok(addedBookId);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook([FromRoute] Guid id)
    {
        return NoContent();
    }
}
