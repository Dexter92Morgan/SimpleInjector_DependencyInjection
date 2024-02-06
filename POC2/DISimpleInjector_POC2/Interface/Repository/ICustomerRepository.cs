using DISimpleInjector_POC2.Model;

namespace DISimpleInjector_POC2.Interface.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}
