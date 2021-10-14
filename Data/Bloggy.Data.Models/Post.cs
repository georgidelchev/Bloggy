using System.ComponentModel.DataAnnotations;

using Bloggy.Data.Common.Models;

namespace Bloggy.Data.Models
{
    public class Post : BaseDeletableModel<int>
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
