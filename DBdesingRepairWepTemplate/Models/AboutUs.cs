using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Models
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Text { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(250)]
        public string IconTitle { get; set; }
        [MaxLength(250)]
        public string IconText { get; set; }
        [MaxLength(50)]
        public string Img { get; set; }
    }
}
