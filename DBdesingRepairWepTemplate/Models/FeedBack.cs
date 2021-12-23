using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Models
{
    public class FeedBack
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Job { get; set; }
        [MaxLength(250)]
        public string About { get; set; }
    }
}
