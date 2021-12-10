using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheForum.Data.Models
{
    [Table("Topics")]
    public class Topic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } 

        [Required]
        public string Content { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string UserName { get; set; }
 
        public DateTime Creation_Date { get; set; } 

        //Foreign key for Topic
        public int BoardID { get; set; }
        public Board Board { get; set; }


    }
}
