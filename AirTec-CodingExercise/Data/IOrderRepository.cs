using AirTec_CodingExercise.Domain;
using System.Collections.Generic;

namespace AirTec_CodingExercise.Data
{
    internal interface IOrderRepository
    {
        IEnumerable<Order> LoadOrdersFromFile(string path);
        IEnumerable<Order> GetOrders();
    }
}