using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace diploma.Models
{
    [Table("users")]
    public class User       
    {
        public long UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string IsAdmin { get; set; }
    }
    [Table("recipes")]
    public class Recipe
    {
        public long RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public string Category { get; set; }
        public string Yield { get; set; }
        public string Img { get; set; }

    }
}
