using DISimpleInjector_POC2.Interface.Repository;
using DISimpleInjector_POC2.Model;

namespace DISimpleInjector_POC2.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            var customer = new List<Customer>
            {
                new Customer{ Id = 1, FirstName = "Preetham", LastName ="Gowda"},
                new Customer{ Id = 2, FirstName = "Dexter", LastName = "Morgan"},
                new Customer{ Id = 3, FirstName = "test", LastName = "user"}
            };
            return customer;
        }
    }
}
