﻿namespace BankingManagement.Core.DTOs.User;

public class UserDto
{
    public Guid UserId { get; set; }
    public string Avatar { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string RoleName { get; set; }
}