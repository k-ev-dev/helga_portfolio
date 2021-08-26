using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Helga_portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helga_portfolio.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<SinglePhoto> SinglePhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "871f2cb7-6501-41b5-9324-5d94cca1486f",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "6f753b4f-2929-4c33-8161-ca1a20a0c302",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "koles.ikov@yandex.ru", 
                NormalizedEmail = "KOLES.IKOV@YANDEX.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "871f2cb7-6501-41b5-9324-5d94cca1486f",
                UserId = "6f753b4f-2929-4c33-8161-ca1a20a0c302",
            });

            modelBuilder.Entity<TextField>().HasData(new TextField { 
                Id = new Guid("fc4106a3-232f-4d61-904a-4a698bebd1c8"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("3ac54093-a696-4fdb-8630-5106e491c817"),
                CodeWord = "PageAlbums ",
                Title = "Альбомы"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("c54568a4-0725-446d-8c54-ef00bb737db2"),
                CodeWord = "PageContactsServices",
                Title = "О съемках и мои контакты"
            });
        }
    }
}
