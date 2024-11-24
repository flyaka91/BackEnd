using BackEnd.Models.Responses.BookResponses;

namespace BackEnd.Models.Responses.UserResponses;

public class UserWithBooksResponse : UserResponse
{
    public bool RememberMe { get; set; }
    public DateTime Birthdate { get; set; }
    public List<BookResponse> Books { get; set; }
}
