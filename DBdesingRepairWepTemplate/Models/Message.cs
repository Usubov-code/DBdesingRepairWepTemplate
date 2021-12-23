using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string Subject { get; set; }
        [MaxLength(2000)]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
