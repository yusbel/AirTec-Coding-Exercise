using AirTec_CodingExercise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace AirTec_CodingExercise.Data
{
    internal class OrderRepository : IOrderRepository
    {
        private static List<Order> _orders = new List<Order>();
        public IEnumerable<Order> LoadOrdersFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new InvalidOperationException("File not found");
            }
            var fileContent = File.ReadAllText(path);
            var obj = System.Text.Json.JsonSerializer.Deserialize<JsonObject>(fileContent);

            foreach (var jobj in obj) 
            {
                var orderName = jobj.Key;
                var destinationJObj = jobj.Value.AsObject();
                var destCode = destinationJObj.ToList().First().Value;
                _orders.Add(new Order
                {
                    Id = orderName,
                    AirPortDestinationCode = destCode.ToString()
                });
            }
            return _orders;
        }

        public IEnumerable<Order> GetOrders() 
        {
            return _orders; 
        }
    }
}
