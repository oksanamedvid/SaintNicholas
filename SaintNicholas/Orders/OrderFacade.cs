using System.Collections.Generic;
using SaintNicholas.Post;

namespace SaintNicholas.Orders
{
    public class OrderFacade
    {
        private readonly OrderReader _orderReader;
        private readonly OrderParser _orderParser;

        public OrderFacade()
        {
            _orderReader = new OrderReader();
            _orderParser = new OrderParser();
        }

        public List<Order> GetOrdersForSaintNicholas()
        {
            var ordersString = _orderReader.ReadOrdersFromFile();
            return _orderParser.ParseFromStringToOrder(ordersString);
        }
    }
}
