using System.ComponentModel.DataAnnotations;

namespace Mission06_Purnell.Models
{
    public class NewMovie
    {
        [Key]
        [Required]
        public string Title { get; set; }
        public int Category { get; set; }
        [Required]
        [Range(1888, 2025)]
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        [Required]
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
