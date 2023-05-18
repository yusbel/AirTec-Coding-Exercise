// See https://aka.ms/new-console-template for more information


using AirTec_CodingExercise;

var airTec = new AirTec();

airTec.AddFlight("1", "YUL", "Montrel", "YYY", "Sample City");

airTec.ListFlights();

airTec.LoadOrdersFromFile();

airTec.AssignOrdersToFlight();

airTec.ListAssignedOrder();

Console.WriteLine("AirTec coding exercise, Press any key to close");

