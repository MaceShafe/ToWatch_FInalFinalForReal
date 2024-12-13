using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToWatch_FInalFinalForReal.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public required string Title { get; set; }

        [StringLength(400)]
        public string? Description { get; set; }
        [MaxLength(1)]
        public int Rating {  get; set; } 
        public int PriorityID { get; set; }

        [ForeignKey("PriorityId")]
        public Priority Priority { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User? User { get; set; }

    }
}
