﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Books.Domain.Profiles.Dtos
{
    [Table("Covers")]
    public class CoverDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(55)]
        public string? Name { get; set; }
    }
}
