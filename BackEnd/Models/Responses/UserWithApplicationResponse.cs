namespace BackEnd.Models.Responses;

public class UserWithApplicationResponse : UserResponse
{
    public DateTime ApplicationDate { get; set; }
    public List<ApplicationResponse> Applications { get; set; }
}
