namespace BackEnd.Models.Requests;

public class CreateApplicationRequest
{
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; }
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }
    
}
