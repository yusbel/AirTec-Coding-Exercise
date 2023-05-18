using AirTec_CodingExercise.Domain;

namespace AirTec_CodingExercise.Service
{
    internal interface IFlightService
    {
        bool AddFlight(string day, string fromCode, string fromCity, string toCode, string toCity);
        IEnumerable<Flight> GetFlights();
    }
}