using Microsoft.EntityFrameworkCore;

namespace KishanKumarDas_Assignment2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "bootstrap", Name = "Bootstrap" },
                new Topic { TopicId = "csharp", Name = "C#" },
                new Topic { TopicId = "javascript", Name = "JavaScript" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "general", Name = "General" },
                new Category { CategoryId = "history", Name = "History" }
            );

            modelBuilder.Entity<Faq>().HasData(
                new Faq { FaqId = 1, Question = "What is Bootstrap?", Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.", TopicId = "bootstrap", CategoryId = "general" },
                new Faq { FaqId = 2, Question = "What is C#?", Answer = "A general purpose object oriented language that uses a concise, Java-like syntax.", TopicId = "csharp", CategoryId = "general" },
                new Faq { FaqId = 3, Question = "What is JavaScript?", Answer = "A general purpose scripting language that executes in a web browser.", TopicId = "javascript", CategoryId = "general" },
                new Faq { FaqId = 4, Question = "When was Bootstrap first released?", Answer = "In 2011.", TopicId = "bootstrap", CategoryId = "history" },
                new Faq { FaqId = 5, Question = "When was C# first released?", Answer = "In 2002.", TopicId = "csharp", CategoryId = "history" },
                new Faq { FaqId = 6, Question = "When was JavaScript first released?", Answer = "In 1995", TopicId = "javascript", CategoryId = "history" }
            );
        }
    }
}
