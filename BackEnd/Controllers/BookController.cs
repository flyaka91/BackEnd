using BackEnd.Models.Requests.BookRequest;
using BackEnd.Models.Requests.UserRequests;
using BackEnd.Models.Responses.BookResponses;
using BackEnd.Models.Responses.UserResponses;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("api/books")]
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

    [HttpPut("{id}")]
    public IActionResult UpdateBook([FromRoute] Guid id, [FromBody] UpdateBookRequest request)
    {
        return NoContent();
    }
                
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
