namespace BackEnd.Models.Requests.BookRequest;

public class AddBookRequest
{
    public Guid BookId { get; set; }
    public string BookName { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }
}
