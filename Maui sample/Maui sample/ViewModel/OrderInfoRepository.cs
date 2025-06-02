using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_sample
{
    public class OrderInfoRepository
    {
        public ObservableCollection<OrderInfo> OrderInfoCollection { get; set; }

        public OrderInfoRepository()
        {
            OrderInfoCollection = new ObservableCollection<OrderInfo>();
            GenerateOrders();
        }

        private void GenerateOrders()
        {
            Random random = new Random();

            string[] cities = { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "San Francisco", "Dallas", "Miami", "Atlanta", "Seattle" };

            Dictionary<string, double> productPrices = new Dictionary<string, double>
        {
            { "Laptop", 1200.0 }, { "Smartphone", 800.0 }, { "Tablet", 500.0 },
            { "Headphones", 150.0 }, { "Smartwatch", 200.0 }, { "Desktop PC", 1000.0 },
            { "Gaming Console", 400.0 }, { "Fitness Tracker", 100.0 }, { "Router", 75.0 },
            { "Smart TV", 900.0 }, { "Drone", 600.0 }, { "VR Headset", 350.0 },
            { "Graphics Card", 800.0 }, { "Power Bank", 50.0 }, { "Projector", 450.0 },
            { "Microphone", 80.0 }, { "Webcam", 60.0 }, { "E-reader", 120.0 }
        };

            var products = new List<string>(productPrices.Keys);

            for (int i = 0; i < 100; i++)
            {
                string product = products[i % products.Count];
                double price = productPrices[product];
                double shipmentPrice = random.Next(1, 100) + random.NextDouble();
                string city = cities[i % cities.Length];

                OrderInfoCollection.Add(new OrderInfo(1000 + i, 1700 + i, product, city, price, shipmentPrice));
            }
        }
    }
}
