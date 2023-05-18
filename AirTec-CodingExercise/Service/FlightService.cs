using AirTec_CodingExercise.Data;
using AirTec_CodingExercise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTec_CodingExercise.Service
{
    internal class FlightService : IFlightService
    {
        private readonly IFlightRepository _repository;

        public FlightService() : this(new FlightRepository())
        {
        }
        public FlightService(IFlightRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Adding flights
        /// </summary>
        /// <param name="day"></param>
        /// <param name="fromCode"></param>
        /// <param name="fromCity"></param>
        /// <param name="toCode"></param>
        /// <param name="toCity"></param>
        /// <returns></returns>
        public bool AddFlight(string day, string fromCode, string fromCity, string toCode, string toCity)
        {
            var flight = new Flight()
            {
                Id = Guid.NewGuid().ToString(),
                Day = day,
                AirPortFrom = new AirPort()
                {
                    Id = Guid.NewGuid().ToString(),
                    Code = fromCode,
                    Name = fromCity
                },
                AirPortTo = new AirPort()
                {
                    Id = Guid.NewGuid().ToString(),
                    Code = toCode,
                    Name = toCity
                }
            };
            _repository.AddFlight(flight);
            return true;
        }

        public IEnumerable<Flight> GetFlights()
        {
            return _repository.GetFlights();
        }
    }
}
