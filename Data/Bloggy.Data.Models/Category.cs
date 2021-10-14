using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Bloggy.Data.Common.Models;

namespace Bloggy.Data.Models
{
    public class Category : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
            = new HashSet<Post>();
    }
}
