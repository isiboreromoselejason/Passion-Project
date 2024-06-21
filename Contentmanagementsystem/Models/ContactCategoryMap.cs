using Contentmanagementsystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactManagementSystem.Models
{
    public class ContactCategoryMap
    {
        [Key]
        public int Id {  get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

        public int CategoryId { get; set; }
        [NotMapped]
        public Category Category { get; set; }
    }
}
