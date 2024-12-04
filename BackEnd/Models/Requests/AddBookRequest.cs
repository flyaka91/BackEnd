namespace BackEnd.Models.Requests;

public class AddBookRequest
{
    public Guid BookId { get; set; }
    public string BookName { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }

    public enum Status
    {
        Available,
        Unavailable
    }
}
