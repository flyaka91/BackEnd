﻿namespace BackEnd.Models.Responses.BookResponses;

public class BookResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price {  get; set; }
}
