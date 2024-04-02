using Grpc.Core;
using Grpc.Heartbeats;

Console.WriteLine("Hello, Client!");

GrpcHeartbeats.ClientConfigure("http://127.0.0.1", 3000);

string choice;

Console.WriteLine("\nChoose an option:");
Console.WriteLine("1. Register");
Console.WriteLine("2. Kick client");
Console.WriteLine("3. Unregister Klajent");
Console.WriteLine("Type 'exit' to quit");

while (true)
{
    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            RegisterClient();
            break;
        case "2":
            HeartbeatClient();
            break;
        case "3":
            UnregisterClient();
            break;
        case "exit":
            Console.WriteLine("Exiting...");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

void UnregisterClient()
{
    try
    {
        Console.WriteLine("Enter client's name:");
        var name = Console.ReadLine();

        GrpcHeartbeats.UnregisterClientAsync(name);
    }
    catch (RpcException e)
    {
        Console.WriteLine($"Caught RCP exception: code: {e.StatusCode}, status: {e.Status}, message: {e.Message}");
    }
}

void HeartbeatClient()
{
    try
    {
        Console.WriteLine("Enter client's name:");
        var name = Console.ReadLine();
        GrpcHeartbeats.Heartbeat(name);
    }
    catch (RpcException e)
    {
        Console.WriteLine($"Caught RCP exception: code: {e.StatusCode}, status: {e.Status}, message: {e.Message}");
    }
}

void RegisterClient()
{
    try
    {
        Console.WriteLine("Enter client's name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter client's timeout:");
        var timeout = int.Parse(Console.ReadLine());
        GrpcHeartbeats.RegisterCLientAsync(name, timeout);
    }
    catch (RpcException e)
    {
        Console.WriteLine($"Caught RCP exception: code: {e.StatusCode}, status: {e.Status}, message: {e.Message}");
    }
}