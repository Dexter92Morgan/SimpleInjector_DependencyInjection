using DISimpleInjector.Interface;

namespace DISimpleInjector.DataAccessLayer
{
    public class DataAccessLayer : ICart
    {
        public string AddtoCart()
        {
            string val = "Simple Injector POc";
            Console.WriteLine(val);
            return val;
        }
    }
}
