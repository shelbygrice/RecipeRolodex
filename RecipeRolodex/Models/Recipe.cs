using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecipeRolodex.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }

        public Guid UserId { get; set; }
        [Required]
        [DisplayName("Recipe")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Ingredients")]
        public string Ingredients { get; set; }

        [DefaultValue(false)]
        [DisplayName("Favorite")]
        public bool IsStarred { get; set; }

        [Required]
        [DisplayName("Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

        //public virtual ICollection<User> User { get; set; }
    }
}