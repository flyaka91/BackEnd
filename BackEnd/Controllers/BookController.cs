using BackEnd.Models.Requests;
using BackEnd.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    //"api/book/add"
    [HttpPost]
    public ActionResult<Guid> AddBook([FromBody] AddBookRequest request)
    {
        var addedBookId = Guid.NewGuid();
        return Ok(addedBookId);
    }

    //"api/book/{id}"
    [HttpDelete("{id}")]
    public IActionResult DeleteBook([FromRoute] Guid id)
    {
        return NoContent();
    }

    //"api/book/{id}"
    [HttpPut("{id}")]
    public IActionResult UpdateBook([FromRoute] Guid id, [FromBody] UpdateBookRequest request)
    {
        return NoContent();
    }
    
    //"api/book/"            
    [HttpGet]
    public ActionResult<List<BookResponse>> GetBooks()
    {
        return Ok();
    }

    //[HttpGet]
    //public ActionResult<BookResponse> GetBookById()
    //{
    //    var user = new BookResponse();
    //    return Ok(user);
    //}
}
