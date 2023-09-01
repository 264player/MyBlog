using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlog.Models
{
    [Table("blogtable")]
    public class ABContent
    {
        public ABContent(string bId,string content) 
        {
            BId = bId;
            Content = content;
        }
        [Column("bid")]
        public string? BId { get; set; }
        [Column("blogcontent")]
        public string? Content { get; set; }
    }
}
