using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyBlog.Models;

namespace MyBlog.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            Seed(modelBuilder);
        }

        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology" },
                new Category { Id = 2, Name = "Health & Welness" },
                new Category { Id = 3, Name = "Career & Entrepreneurship" },
                new Category { Id = 4, Name = "Travel" },
                new Category { Id = 5, Name = "Fashion" },
                new Category { Id = 6, Name = "Food & Recipes" },
                new Category { Id = 7, Name = "Art & Culture" },
                new Category { Id = 8, Name = "Movies & Series & Books" },
                new Category { Id = 9, Name = "Education & Personel Development" },
                new Category { Id = 10, Name = "Finance" }


            );


            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "Technology Post 1",
                    Content = "Content of Tech Post 1",
                    Author = "Ebru Naz Gül",
                    PublishedDate = new DateTime(2025, 1, 1),
                    CategoryId = 1,
                    FeatureImagePath = "tech_image.jpg",
                },
                new Post
                {
                    Id = 2,
                    Title = "Health Post 1",
                    Content = "Content of Health Post 1",
                    Author = "Ahmet Yıldız",
                    PublishedDate = new DateTime(2025, 1, 1),
                    CategoryId = 2,
                    FeatureImagePath = "health_image.jpg",
                },
                new Post
                {
                    Id = 3,
                    Title = "Career Post 1",
                    Content = "Content of Career Post 1",
                    Author = "Ahmet Kaya",
                    PublishedDate = new DateTime(2025, 1, 1),
                    CategoryId = 3,
                    FeatureImagePath = "career_image.jpg",
                },
                new Post
                {
                    Id = 4,
                    Title = "Travel Post 1",
                    Content = "Content of Travel Post 1",
                    Author = "Elif Yılmaz",
                    PublishedDate = new DateTime(2025, 1, 1),
                    CategoryId = 4,
                    FeatureImagePath = "travel_image.jpg",
                },
                new Post
                {
                    Id = 5,
                    Title = "Fashion Post 1",
                    Content = "Content of Fashion Post 1",
                    Author = "Nur Uslu",
                    PublishedDate = new DateTime(2025, 1, 1),
                    CategoryId = 5,
                    FeatureImagePath = "fashion_image.jpg",
                },
                new Post
                {
                    Id = 6,
                    Title = "Food Post 1",
                    Content = "Content of Food Post 1",
                    Author = "Somer Sivrioğlu",
                    PublishedDate = new DateTime(2025, 1, 1),
                    CategoryId = 6,
                    FeatureImagePath = "food_image.jpg",
                },
                 new Post
                 {
                     Id = 7,
                     Title = "Art Post 1",
                     Content = "Content of Art Post 1",
                     Author = "Duru Özkök",
                     PublishedDate = new DateTime(2025, 1, 1),
                     CategoryId = 7,
                     FeatureImagePath = "art_image.jpg",
                 },
                  new Post
                  {
                      Id = 8,
                      Title = "Movies Post 1",
                      Content = "Content of Movies Post 1",
                      Author = "Çağan Irmak",
                      PublishedDate = new DateTime(2025, 1, 1),
                      CategoryId = 8,
                      FeatureImagePath = "movies_image.jpg",
                  },
                  new Post
                  {
                      Id = 9,
                      Title = "Education Post 1",
                      Content = "Content of Education Post 1",
                      Author = "Fatih Yıldırım",
                      PublishedDate = new DateTime(2025, 1, 1),
                      CategoryId = 9,
                      FeatureImagePath = "edu_image.jpg",
                  },
                  new Post
                  {
                      Id = 10,
                      Title = "Finance Post 1",
                      Content = "Content of Finance Post 1",
                      Author = "Özlem Denizmen",
                      PublishedDate = new DateTime(2025, 1, 1),
                      CategoryId = 10,
                      FeatureImagePath = "finance_image.jpg",
                  }
            );
        }

    }
}
