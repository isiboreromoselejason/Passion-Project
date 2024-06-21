using ContactManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Contentmanagementsystem.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
            public int UserId { get; set; }
            public string CategoryName { get; set; }

            public User User { get; set; }
        [NotMapped]
            public ICollection<ContactCategoryMap> ContactCategoryMaps { get; set; }
        public Category()
        {
                
        }

    }
    }
