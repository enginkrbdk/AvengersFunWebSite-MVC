using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AvengersMVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string CoverImgUrl { get; set; }
        public DateTime RelaseDate { get; set; }
        public string Description { get; set; }


        public virtual List<Comment> Comments { get; set; }
        public int CharacterID { get; set; }
        public virtual Character Character { get; set; }

    }
}