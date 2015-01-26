﻿namespace BunnyCraft.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    using BunnyCraft.Models;

    public class BunnyModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        public string Name { get; set; }

        [Range(0, 100)]
        public double Health { get; set; }

        [Required]
        public ColorType ColorType { get; set; }
    }
}
