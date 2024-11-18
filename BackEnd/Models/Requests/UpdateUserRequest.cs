namespace BackEnd.Models.Requests;

public class UpdateUserRequest
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
}
