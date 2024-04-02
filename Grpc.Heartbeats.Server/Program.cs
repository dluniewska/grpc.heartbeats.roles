using Grpc.Heartbeats;

Console.WriteLine("Hello, Server!");

GrpcHeartbeats.HostConfigure("localhost", 3000);

string choice;

Console.WriteLine("\nChoose an option:");
Console.WriteLine("1. CheckClients");
Console.WriteLine("Type 'exit' to quit");

while (true)
{
    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            CheckClients();
            break;
        case "exit":
            Console.WriteLine("Exiting...");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

void CheckClients()
{
    var statuses = GrpcHeartbeats.CheckClientStatus();

    Console.WriteLine($"Are alive: {statuses.Item1}");
    Console.WriteLine($"Dead: {string.Join(", ", statuses.Item2)}");
}