namespace BackEnd.Models.Requests;

public class UpdateBookRequest
{
    public string BookName { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }
}
