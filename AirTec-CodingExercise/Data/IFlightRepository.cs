using AirTec_CodingExercise.Domain;

namespace AirTec_CodingExercise.Data
{
    internal interface IFlightRepository
    {
        void AddFlight(Flight flight);
        IEnumerable<Flight> GetFlights();
    }
}