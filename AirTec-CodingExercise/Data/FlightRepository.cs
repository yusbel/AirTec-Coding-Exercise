using AirTec_CodingExercise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTec_CodingExercise.Data
{
    internal class FlightRepository : IFlightRepository
    {
        private static List<Flight> Flights { get; set; } = new List<Flight>()
            {
                new Flight()
                {
                    Id = Guid.NewGuid().ToString(),
                    Day = "1",
                    AirPortFrom = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YUL",
                                        Name = "Montreal"
                                    },
                    AirPortTo = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YYZ",
                                        Name = "Toronto"
                                    },
                    FlightNum = 1
                },
                new Flight()
                {
                    Id = Guid.NewGuid().ToString(),
                    Day = "1",
                    AirPortFrom = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YUL",
                                        Name = "Montreal"
                                    },
                    AirPortTo = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YYC",
                                        Name = "Calgary"
                                    }, FlightNum = 2
                },
                new Flight()
                {
                    Id = Guid.NewGuid().ToString(),
                    Day = "1",
                    AirPortFrom = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YUL",
                                        Name = "Montreal"
                                    },
                    AirPortTo = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YVR",
                                        Name = "Vancouver"
                                    }, FlightNum = 3
                },
                new Flight()
                {
                    Id = Guid.NewGuid().ToString(),
                    Day = "2",
                    AirPortFrom = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YUL",
                                        Name = "Montreal"
                                    },
                    AirPortTo = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YYZ",
                                        Name = "Toronto"
                                    }, FlightNum = 4
                },
                new Flight()
                {
                    Id = Guid.NewGuid().ToString(),
                    Day = "2",
                    AirPortFrom = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YUL",
                                        Name = "Montreal"
                                    },
                    AirPortTo = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YYC",
                                        Name = "Calgary"
                                    }, FlightNum = 5
                },
                new Flight()
                {
                    Id = Guid.NewGuid().ToString(),
                    Day = "2",
                    AirPortFrom = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YUL",
                                        Name = "Montreal"
                                    },
                    AirPortTo = new AirPort()
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        Code = "YVR",
                                        Name = "Vancouver"
                                    }, FlightNum = 6
                }
        };

        public IEnumerable<Flight> GetFlights()
        {
            return Flights;
        }

        public void AddFlight(Flight flight)
        {
            flight.FlightNum = Flights.Count + 1;
            Flights.Add(flight);
        }
    }
}
