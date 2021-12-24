using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }

        [MaxLength(250)]
        public string Text { get; set; }

        [MaxLength(50)]
        public string Img { get; set; }
        


        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }






    }
}
