using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AvengersMVC.Models
{
    public class Comment
    {   [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CmdDate { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User Users { get; set; }


        public int MovieId { get; set; }
        public Movie Movies { get; set; }


    }
}