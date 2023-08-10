using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeasurementsWebAPI.BusinessLogic.Models
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Password { get; set; } = null!;
    }
}
