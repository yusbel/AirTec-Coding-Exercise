using AirTec_CodingExercise.Data;
using AirTec_CodingExercise.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTec_CodingExercise
{
    internal class AirTec
    {
        private readonly IFlightService _flightService;
        private readonly IOrderService _orderService;

        public AirTec() : this(new FlightService(new FlightRepository()), new OrderService()) 
        { }
        public AirTec(IFlightService flightService, IOrderService orderService)
        {
            _flightService = flightService;
            _orderService = orderService;
        }

        public void AddFlight(string day, string fromCode, string fromCity, string toCode, string toCity) 
        {
            _flightService.AddFlight(day, fromCode, fromCity, toCode, toCity);
        }

        public void ListFlights() 
        {
            foreach(var flight in _flightService.GetFlights()) 
            {
                Console.WriteLine($"Flight: {flight.FlightNum}, departure: {flight.AirPortFrom.Code}, arrival: {flight.AirPortTo.Code}, day: {flight.Day}");
            }
        }

        public void LoadOrdersFromFile() 
        {
            _orderService.LoadOrdersFromFile();
        }

        public void AssignOrdersToFlight() 
        {
            _orderService.AssignOrder(_flightService);
        }

        public void ListAssignedOrder() 
        {
            _orderService.ListAssignedOrders();
        }
    }
}
