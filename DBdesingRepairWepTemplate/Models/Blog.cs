using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }

        public DateTime CreatedTime { get; set; }
        [MaxLength(500)]
        public string Text { get; set; }
        [MaxLength(500)]
        public string ContentText { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Img")]
        public int ImgId { get; set; }
        public Img Img { get; set; }


        public List<TagToBlog> TagToBlogs { get; set; }

        public List<Comment>  Comments { get; set; }



    }
}
