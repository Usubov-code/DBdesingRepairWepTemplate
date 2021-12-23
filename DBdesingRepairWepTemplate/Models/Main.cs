using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Models
{
    public class Main
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string SubTitle { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Text { get; set; }
        [MaxLength(50)]
        public string Img { get; set; }
    }
}
