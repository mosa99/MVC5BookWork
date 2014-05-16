﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using ModelValidation.Infrastructure;

//namespace ModelValidation.Models
//{
//    public class Appointment : IValidatableObject
//    {
//        public string ClientName { get; set; }
//        [DataType(DataType.Date)]
//        public DateTime Date { get; set; }
//        public bool TermsAccepted { get; set; }
//        public IEnumerable<ValidationResult> Validate(ValidationContext  validationContext)
//        {
//            List<ValidationResult> errors = new List<ValidationResult>();
//            if (string.IsNullOrEmpty(ClientName))
//            {
//                errors.Add(new ValidationResult("Please enter your name"));
//            }
//            if (DateTime.Now > Date)
//            {
//                errors.Add(new ValidationResult("Please enter a date in the future"));
//            }
//            if (errors.Count == 0 && ClientName == "Joe"
//            && Date.DayOfWeek == DayOfWeek.Monday)
//            {
//                errors.Add(
//                new ValidationResult("Joe cannot book appointments on Mondays"));
//            }
//            if (!TermsAccepted)
//            {
//                errors.Add(new ValidationResult("You must accept the terms"));
//            }
//            return errors;
//        }
//    }
//}

namespace ModelValidation.Models
{
    public class Appointment
    {
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string ClientName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public bool TermsAccepted { get; set; }
    }
}