namespace Systemtest.Models.DbEntities
{
    public class CustomerListViewModel
    {
        public List<CustomerViewModel> Customers { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}