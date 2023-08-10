using MeasurementsWebAPI.BusinessLogic.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeasurementsWebAPI.BusinessLogic.Models
{
    public partial class Atm
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        [MinValue(0, "Length cannot be less than 0")]
        public int Length { get; set; }

        [Required]
        [MinValue(0,"Width cannot be less than 0")]
        [MaxValue(800,"Width cannot be more than 800")]
        public int Width { get; set; }

        [Required]
        [MinValue(100, "Height cannot be less than 0")]
        public int Height { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
