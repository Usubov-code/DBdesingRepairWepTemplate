using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Models
{
    public class Contact
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public string CreatedTime { get; set; }
    }
}
