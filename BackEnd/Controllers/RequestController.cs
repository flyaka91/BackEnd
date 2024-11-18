using BackEnd.Models.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RequestController : ControllerBase;
//{
    //[HttpPost]
    //public ActionResult<Guid> CreateRequest([FromBody] CreateRequest request)
    //{
    //    var addedBookId = Guid.NewGuid();
    //    return Ok(addedBookId);
    //сраный реквест реквест реквест, спросить у препода про нейминг, заявка - реквест, - в модельках запрос это тоже реквест. можно вместо реквест Sign? заявка типа
//    }
//}
