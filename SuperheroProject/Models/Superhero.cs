using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperheroProject.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        public string superheroName { get; set; }
        public string alterEgoFirstName { get; set; }
        public string alterEgoLastName { get; set; }
        public string primaryAbility { get; set; }
        public string secondaryAbility { get; set; }
        public string catchphrase { get; set; }
    }
}