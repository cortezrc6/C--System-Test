using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systemtest.Models.DbEntities
{
    public class CustomerViewModel
    {
        [DisplayName("CustomerID")]
        public int CustomerID { get; set; }
        [DisplayName("CustomerName")]
        public string CustomerName { get; set; }

        [DisplayName("Place")]
        public string Place { get; set; }

    }
}
