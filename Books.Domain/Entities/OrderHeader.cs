﻿using Books.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Domain.Entities
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        public string? ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser? ApplicationUser { get; set; }

        [Required]
        [MaxLength(55)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(55)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Street Adress")]
        public string? StreetAddress { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? State { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [DataType(DataType.PostalCode)]
        public string? PostalCode { get; set; }

        [Display(Name = "Company Name")]
        [ValidateNever]
        public Company? Company { get; set; }

        [Required]
        public string OrderDate { get; set; } = string.Empty;
        public double OrderTotal { get; set; } = 0;
        public string? OrderStatus { get; set; }

        public string PaymentStatus { get; set; } = string.Empty;

        // Stripe Configutation.
        public string PaymentIntentId { get; set; } = string.Empty;
        public string SessionId { get; set; } = string.Empty;

    }
}
