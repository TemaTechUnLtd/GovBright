﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovBright.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        public Address Address { get; set; }

        public bool LightingOk { get; set; }

        [Range(1, 10, ErrorMessage = "Please enter a valid brightness level between 1 and 1-10")]
        public int Brightness { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
