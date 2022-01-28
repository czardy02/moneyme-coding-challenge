using QuoteCalculator.DbContexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.Data
{
    public class User
    {
        public User() { }

        public User(int UserId) {
            this.UserId = UserId;
        }

        public User(string firstName, string lastName, string title, DateTime dateOfBirth, string mobile, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Title = title;
            this.DateOfBirth = dateOfBirth;
            this.Mobile = mobile;
            this.Email = email;
        }

        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool IsBlackListed { get; set; }

    }
}
