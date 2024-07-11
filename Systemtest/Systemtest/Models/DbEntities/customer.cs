using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systemtest.Models.DbEntities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string CustomerName { get; set; }
        public string Place { get; set; }
       
    }
}
