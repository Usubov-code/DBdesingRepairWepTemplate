using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Models
{
    public class setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(250)]
        public string Adress { get; set; }
        [MaxLength(50)]
        public string OpenIn { get; set; }

    }
}
