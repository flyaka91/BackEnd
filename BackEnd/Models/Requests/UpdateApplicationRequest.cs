namespace BackEnd.Models.Requests;

public class UpdateApplicationRequest
{
    public Guid ApplicationId { get; set; }
    public Guid User { get; set; }
    public Guid Book { get; set; }
}
