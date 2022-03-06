using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToiThichLapTrinh.Server.Datas.Entities;

[Table("Commands")]
public class Command
{
    [Key]
    [MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public string Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
}