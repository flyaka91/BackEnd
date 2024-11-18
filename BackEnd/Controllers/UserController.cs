using BackEnd.Models.Requests;
using BackEnd.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using LoginRequest = BackEnd.Models.Requests.LoginRequest;

namespace BackEnd.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    
    [HttpPost]
    public ActionResult<Guid> Register([FromBody] RegisterUserRequest request)
    {
        var addedUserId = Guid.NewGuid();
        return Ok(addedUserId);
    }

    //"api/user/login"
    [HttpPost("login")]
    public IActionResult LogIn([FromBody] LoginRequest request)
    {
        return Ok();
    }

    //"api/user/{id}"
    [HttpGet("{id}")]
    public ActionResult<UserWithBooksResponse> GetUserById([FromRoute]Guid id)
    {
        var user = new UserWithBooksResponse();
        return Ok(user);
    }

    //"api/user/{id}"
    [HttpGet]
    public ActionResult<List<UserResponse>> GetUsers()
    {
        return Ok();
    }

    //"api/user/{id}"
    [HttpPut("{id}")]
    public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserRequest request)
    {
        return NoContent();
    }

    //"api/user/{id}"
    [HttpDelete("{id}")]
    public IActionResult DeleteUser([FromRoute] Guid id)
    {
        return NoContent();
    }

    //"api/user/{id}/deactivate"
    [HttpPatch("{id}/deactivate")]
    public IActionResult DeactivateUser([FromRoute] Guid id)
    {
        return NoContent();
    }
}
