using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Models
{
    public class Service
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Text { get; set; }
    }
}
