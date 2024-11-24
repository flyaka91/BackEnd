using BackEnd.Models.Requests.ApplicationRequests;
using BackEnd.Models.Requests.UserRequests;
using BackEnd.Models.Responses.ApplicationResponses;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("api/applications")]
public class ApplicationController : ControllerBase
{
    
    [HttpPost]
    public ActionResult<Guid> Create([FromBody] CreateApplicationRequest request)
    
    {
        var CreatedApplicationId = Guid.NewGuid();
        return Ok(CreatedApplicationId);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteApplication([FromRoute] Guid id)
    {
        return NoContent();
    }
}


