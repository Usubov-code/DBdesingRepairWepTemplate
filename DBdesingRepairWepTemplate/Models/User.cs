using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string Job { get; set; }
        [MaxLength(50)]
        public string About { get; set; }

        [ForeignKey("Social")]
        public int SocialId { get; set; }

        public Social Social { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
