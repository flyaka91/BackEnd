namespace BackEnd.Models.Requests;

public class AddBookRequest
{
    public Guid BookId { get; set; }
    public string BookName {  get; set; }
    public string description { get; set; }
    public double Price { get; set; }
    public string Autor {  get; set; }
    public DateTime PublicationDate { get; set; }
    public enum available
    {
        yes,
        unavailable,
        Unknown
    }
        

}
