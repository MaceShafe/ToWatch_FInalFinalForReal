using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToWatch_FInalFinalForReal.Models
{
    public class User
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

//App will be intended for offline use, no need for emails and passwords,
//it'll just have your name, maybe there's a better way to do this
    }
}
