using Microsoft.AspNetCore.Mvc;
using Systemtest.DAL;
using Systemtest.Models.DbEntities;
using X.PagedList; // Ensure only this namespace is used

namespace Systemtest.Controllers
{
    public class CustomerController : Controller
    {
        private readonly DbCustomerContext _context;

        public CustomerController(DbCustomerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;
            int pageSize = 3; // You can change this to the desired number of items per page

            var customers = _context.Customers.ToList();

            if (customers != null && customers.Any())
            {
                List<CustomerViewModel> customerList = new List<CustomerViewModel>();

                foreach (var customer in customers)
                {
                    var customerViewModel = new CustomerViewModel
                    {
                        CustomerID = customer.CustomerID,
                        CustomerName = customer.CustomerName ?? "Unknown",
                        Place = customer.Place ?? "Unknown"
                        // Add more properties as needed
                    };

                    customerList.Add(customerViewModel);
                }

                var pagedCustomerList = customerList.ToPagedList(pageNumber, pageSize);
                return View(pagedCustomerList);
            }
            else
            {
                return View(new List<CustomerViewModel>().ToPagedList(1, pageSize));
            }
        }
    }
}
