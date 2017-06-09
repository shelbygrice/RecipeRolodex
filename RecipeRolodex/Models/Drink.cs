using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecipeRolodex.Models
{
    public class Drink
    {
        [Key]
        public int DrinkId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [DefaultValue(false)]
        [Display(Name = "Favorite")]
        public bool IsStarred { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

        //public virtual ICollection<User> User { get; set; }
    }
}