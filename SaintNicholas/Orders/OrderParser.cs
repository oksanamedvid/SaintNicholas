using System;
using System.Collections.Generic;
using SaintNicholas.Post;

namespace SaintNicholas.Orders
{
    public class OrderParser
    {
        public List<Order> ParseFromStringToOrder(List<string> ordersString)
        {
            var orders = new List<Order>();
            ordersString.ForEach(orderString =>
                {
                    var orderItems = orderString.Split(" ");
                    Enum.TryParse(orderItems[0], out GiftGender gender);
                    Enum.TryParse(orderItems[1], out GiftType type);
                    orders.Add(new Order
                    {
                        GiftGender = gender,
                        GiftType = type,
                        ChildName = orderItems[2],
                        ChildAge = Int32.Parse(orderItems[3]),
                        GoodDeedsCount = Int32.Parse(orderItems[4]),
                        BadDeedsCount = Int32.Parse(orderItems[5])
                    });

                }
            );
            return orders;
        }
    }
}
