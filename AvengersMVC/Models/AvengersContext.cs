using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AvengersMVC.Models
{
    public class AvengersContext:DbContext
    {
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Movie>  Movies { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}