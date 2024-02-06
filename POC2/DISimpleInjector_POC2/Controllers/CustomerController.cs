using DISimpleInjector_POC2.Interface.Repository;
using DISimpleInjector_POC2.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleInjector;

namespace DISimpleInjector_POC2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(Container container)
        {
            _customerRepository = container.GetInstance<ICustomerRepository>();
        }

        [HttpGet]
        public ActionResult<List<Customer>> GetCustomers()
        {
            var customers = _customerRepository.GetCustomers();
            return customers.ToList();
        }
    }
}
