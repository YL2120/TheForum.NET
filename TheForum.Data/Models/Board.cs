using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheForum.Data.Models
{
    [Table("Board")]
    public class Board
    {
        public int Id { get; set; }

       
        [Column(TypeName = "nvarchar(25)")]
        public string Name { get; set; } = null!;

        
        [Column(TypeName = "nvarchar(40)")]
        public string Description { get; set; } = null!;

        public byte[] Image { get; set; } = null!;
    }
}
