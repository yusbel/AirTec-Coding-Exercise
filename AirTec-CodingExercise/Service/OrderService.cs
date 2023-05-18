using AirTec_CodingExercise.Data;
using AirTec_CodingExercise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTec_CodingExercise.Service
{
    internal class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        private static List<KeyValuePair<Order, Flight>> _assignedOrder = new List<KeyValuePair<Order, Flight>>();

        public OrderService() : this(new OrderRepository()) { }
        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public void LoadOrdersFromFile()
        {
            var filePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\coding-assigment-orders.json"; 
            _repository.LoadOrdersFromFile(filePath);
        }

        public void AssignOrder(IFlightService flightService)
        {
            var flights = flightService.GetFlights();
            foreach (var order in _repository.GetOrders())
            {
                var flight = flights.FirstOrDefault(flight => flight.AirPortTo.Code == order.AirPortDestinationCode && flight.AmountOfOrder < 20);
                if (flight == null)
                {
                    Console.WriteLine($"No flight with capacaty was found for destination code {order.AirPortDestinationCode}");
                    continue;
                }
                flight.AmountOfOrder += 1;
                _assignedOrder.Add(KeyValuePair.Create(order, flight));
            }
        }

        public void ListAssignedOrders()
        {
            foreach (var order in _assignedOrder)
            {
                Console.WriteLine($"order: {order.Key.Id}, flightNumber: {order.Value.FlightNum}, arrival: {order.Value.AirPortTo.Name}, day: {order.Value.Day}");
            }
        }
    }
}
