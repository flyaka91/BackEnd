﻿namespace BackEnd.Models.Requests.UserRequests;

public class UpdateUserRequest
{
    public string UserName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
}