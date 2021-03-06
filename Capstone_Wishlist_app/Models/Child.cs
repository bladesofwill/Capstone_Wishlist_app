﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capstone_Wishlist_app.Models
{
    public class Child
    {
        [Key]        
        public int Child_ID { get; set; }

        [ForeignKey("Family")]
        [Required]
        public int Family_ID { get; set; }

         [Required]
         [Display(Name = "Child's First Name")]
        public string Child_FirstName { get; set; }

         [Required]
        [Display(Name= "Child's Last Name")]
        public string Child_LastName { get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }

        public virtual Family Family { get; set; }
    }
}