using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using ToiThichLapTrinh.Server.Datas.Interfaces;

namespace ToiThichLapTrinh.Server.Datas.Entities;

public sealed class User :  IdentityUser, IDateTracking
{
    public User() { }
    
    public User(string id, string userName, string firstName, string lastName, string email, string phoneNumber, DateTime dob)
    {
        Id = id;
        UserName = userName;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Dob = dob;
    }
    
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    [Required]
    public DateTime Dob { get; set; }

    public int? NumberOfKnowledgeBases { get; set; }

    public int? NumberOfVotes { get; set; }

    public int? NumberOfReports { get; set; }
    
    public DateTime CreateDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}