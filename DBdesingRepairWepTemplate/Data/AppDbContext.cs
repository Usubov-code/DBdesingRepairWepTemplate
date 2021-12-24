using DBdesingRepairWepTemplate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Data
{
    public class AppDbContext:DbContext
    {
       
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
   

        public DbSet<AboutUs> AboutUs { get; set; }

        public DbSet<Ask> Asks { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Img> Imgs { get; set; }
        public DbSet<Main> Mains { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PercentAbout> PercentAbouts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
