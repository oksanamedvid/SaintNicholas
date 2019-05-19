using SaintNicholas.Mediator;
using SaintNicholas.Orders;

namespace SaintNicholas
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new PostSaintNicholasMediator();

            var orderFacade = new OrderFacade();
            var orders = orderFacade.GetOrdersForSaintNicholas();
            orders.ForEach(order => mediator.PostOffice.SendPostProduct(order));
        }
    }
}
