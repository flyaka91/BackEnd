using BackEnd.Models.Requests;
using BackEnd.Models.Requests;
using BackEnd.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("api/applications")]
public class ApplicationController : ControllerBase
{
    //"api/application/Create"
    [HttpPost]
    public ActionResult<Guid> Create([FromBody] CreateApplicationRequest request)
    
    {
        var CreatedApplicationId = Guid.NewGuid();
        return Ok(CreatedApplicationId);
    }
    
    //"api/application/{id}"
    [HttpDelete("{id}")]
    public IActionResult DeleteApplication([FromRoute] Guid id)
    {
        return NoContent();
    }

    //"api/application/{id}"
    [HttpPut("{id}")]
    public ActionResult UpdateApplication([FromRoute] Guid id)
    {
        var UpdatedApplicationId = Guid.NewGuid();
        return Ok(UpdatedApplicationId);
    }
}


