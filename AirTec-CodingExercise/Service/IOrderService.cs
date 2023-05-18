namespace AirTec_CodingExercise.Service
{
    internal interface IOrderService
    {
        void AssignOrder(IFlightService flightService);
        void ListAssignedOrders();
        void LoadOrdersFromFile();
    }
}