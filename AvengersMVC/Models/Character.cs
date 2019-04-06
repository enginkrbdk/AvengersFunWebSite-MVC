using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AvengersMVC.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string CharacterName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public virtual List<Movie> Movies { get; set; }
    }
}