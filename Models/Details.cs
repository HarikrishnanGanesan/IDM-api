using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace IDMApi.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string userPassword { get; set; }
        public long Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string AdhaarNumber { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Gender { get; set; }
    }
}
