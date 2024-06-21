using ContactManagementSystem.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Contentmanagementsystem.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public User User { get; set; }

        [NotMapped]
        public ICollection<ContactCategoryMap> ContactCategoryMaps { get; set; }

        public Contact()
        {
                
        }
    }
}