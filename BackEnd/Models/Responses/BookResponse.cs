namespace BackEnd.Models.Responses;

public class BookResponse
{
    public Guid Id { get; set; }
    public string BookName { get; set; }
    public string description { get; set; }
    public double Price { get; set; }
}
