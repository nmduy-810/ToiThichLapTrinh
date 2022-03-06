using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToiThichLapTrinh.Server.Datas.Entities;

[Table("LabelInKnowledgeBases")]
public class LabelInKnowledgeBase
{
    [MaxLength(50)]
    [Column(TypeName = "varchar(50)")]
    public string LabelId { get; set; }
    
    public int KnowledgeBaseId { get; set; }
}