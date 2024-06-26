﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Contentmanagementsystem.Models
{
    public class User
    {
        [Key]
            public int UserId { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
             [NotMapped]
            public ICollection<Contact> Contacts { get; set; }
            [NotMapped]
            public ICollection<Category> Categories { get; set; }
            }
    }