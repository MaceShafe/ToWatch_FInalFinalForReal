using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToWatch_FInalFinalForReal.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        public string? Name { get; set; }

        public virtual ObservableCollectionListSource<Movie>? Movies { get; } = new();
    }
}
