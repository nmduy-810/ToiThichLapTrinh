using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToiThichLapTrinh.Server.Datas.Entities;

namespace ToiThichLapTrinh.Server.Datas;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions options) : base(options) 
    {
        
    }

    /* Override OnModelCreating is used when you want to use FluentAPI instead of using Annotation */
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Id of IdentityRole if don't set max length is 50, default is MAX and set don't enter unicode value */
        builder.Entity<IdentityRole>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);

        /* Id of IdentityUser if don't set max length is 50, default is MAX*/
        builder.Entity<User>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);

        /* Set two primary key is LabelId, KnowledgeBaseId in LabelInKnowledgeBase table */
        builder.Entity<LabelInKnowledgeBase>().HasKey(x => new { x.LabelId, x.KnowledgeBaseId });

        builder.Entity<Permission>().HasKey(x => new { x.RoleId, x.FunctionId, x.CommandId });

        builder.Entity<Vote>().HasKey(x => new { x.KnowledgeBaseId, x.UserId });

        builder.Entity<CommandInFunction>().HasKey(x => new { x.CommandId, x.FunctionId });

        builder.HasSequence("KnowledgeBaseSequence");
    }

    public DbSet<ActivityLog> ActivityLogs { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Command> Commands { get; set; }
    public DbSet<CommandInFunction> CommandInFunctions { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Function> Functions { get; set; }
    public DbSet<KnowledgeBase> KnowledgeBases { get; set; }
    public DbSet<Label> Labels { get; set; }
    public DbSet<LabelInKnowledgeBase> LabelInKnowledgeBases { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<Vote> Votes { get; set; }
}