using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Collectors.Models
{
    public class Collection
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(55)]
        [MinLength(1)]
        public string Name { get; set; }
        public List<Collectible> Collectibles { get; set; }
        public string UserId  { get; set; }
        public ApplicationUser User { get; set; }
    }
}