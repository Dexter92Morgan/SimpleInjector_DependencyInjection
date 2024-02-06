using DISimpleInjector.Interface;

namespace DISimpleInjector.BussinessLayer
{
    public class BussinessLayer
    {
        private ICart _objcart;

        public BussinessLayer(ICart objcart)
        {
            _objcart = objcart;
        }

        public void InsertCart()
        {
            _objcart.AddtoCart();
        }
    }
}
