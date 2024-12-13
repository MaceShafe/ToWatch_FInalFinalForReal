using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToWatch_FInalFinalForReal.Models
{
    public class Priority
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)] 
        public required string Name { get; set; }
        public int Order {  get; set; }
    }
}
