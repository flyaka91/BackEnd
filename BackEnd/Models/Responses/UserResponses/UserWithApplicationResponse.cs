using BackEnd.Models.Responses.BookResponses;
using BackEnd.Models.Responses.ApplicationResponses;

namespace BackEnd.Models.Responses.UserResponses;

public class UserWithApplicationResponse : UserResponse
{
    public DateTime ApplicationDate { get; set; }
    public List<ApplicationResponse> Applications { get; set; }
}
