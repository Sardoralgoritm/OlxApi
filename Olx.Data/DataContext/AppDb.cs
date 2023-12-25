using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Olx.Domain.Models;

namespace Olx.Data.DataContext;

public class AppDb(DbContextOptions<AppDb> options) : IdentityDbContext<User>(options)
{
    public DbSet<User> users { get; set; }
    public DbSet<Ads> ads { get; set; }
    public DbSet<Category> categories { get; set; }
    public DbSet<Chat> chats { get; set; }
    public DbSet<Image> images { get; set; }
    public DbSet<Message> messages { get; set; }
    public DbSet<Region> regions { get; set; }
    public DbSet<SubRegion> subRegions { get; set; }
    public DbSet<SubCategory> subCategories { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {

        ConfigureAds(builder);
        ConfigureChat(builder);

        base.OnModelCreating(builder);
    }

    private void ConfigureChat(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chat>()
                    .HasMany(i => i.Messages)
                    .WithOne(i => i.Chat)
                    .HasForeignKey(i => i.ChatId)
                    .OnDelete(DeleteBehavior.ClientCascade);
    }
    private void ConfigureAds(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ads>()
                    .HasMany(i => i.Images)
                    .WithOne(i => i.Ads)
                    .HasForeignKey(i => i.AdsId)
                    .OnDelete(DeleteBehavior.ClientCascade);
    }
}
