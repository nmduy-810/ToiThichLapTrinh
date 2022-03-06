using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToiThichLapTrinh.Server.Datas.Interfaces;

namespace ToiThichLapTrinh.Server.Datas.Entities;

[Table("ActivityLogs")]
public class ActivityLog : IDateTracking
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public string Action { get; set; }

    [Required]
    [MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public string EntityName { get; set; }
    
    [MaxLength(500)]
    public string Content { get; set; }

    [Required]
    [MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public string EntityId { get; set; }

    [MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public string UserId { get; set; }
    
    public DateTime CreateDate { get; set; }
    
    public DateTime? LastModifiedDate { get; set; }
}