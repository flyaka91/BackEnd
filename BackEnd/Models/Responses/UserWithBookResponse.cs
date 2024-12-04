namespace BackEnd.Models.Responses;

public class UserWithBooksResponse : UserResponse
{
    public bool RememberMe { get; set; }
    public DateTime Birthdate { get; set; }
    public List<BookResponse> Books { get; set; }
}
