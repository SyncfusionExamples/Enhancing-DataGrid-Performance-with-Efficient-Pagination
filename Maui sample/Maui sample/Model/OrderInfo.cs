using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Maui_sample
{
    public class OrderInfo
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string Product { get; set; }
        public string City { get; set; }
        public double OrderPrice { get; set; }
        public double ShipmentPrice { get; set; }
        public double TotalPrice { get; set; }

        public OrderInfo(int orderId, int customerId, string product, string city, double orderPrice, double shipmentPrice)
        {
            OrderID = orderId;
            CustomerID = customerId;
            Product = product;
            City = city;
            OrderPrice = orderPrice;
            ShipmentPrice = shipmentPrice;
            TotalPrice = orderPrice + shipmentPrice;
        }
    }

}
