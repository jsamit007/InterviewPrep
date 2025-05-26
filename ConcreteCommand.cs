using System;

namespace InterviewPrep.DesignPattern.Command;

#region Core Interfaces

public interface ICommand { }

public interface ICommandHandler<TCommand> where TCommand : ICommand
{
    Task HandleAsync(TCommand command);
}

public interface ICommandBus
{
    Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand;
}

#endregion

#region Command and Handler

public class CreateOrderCommand : ICommand
{
    public Guid OrderId { get; set; }
    public string CustomerName { get; set; }
}

public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand>
{
    public Task HandleAsync(CreateOrderCommand command)
    {
        Console.WriteLine($"[Handler] Creating Order for {command.CustomerName} with ID {command.OrderId}");
        return Task.CompletedTask;
    }
}

#endregion

#region Command Bus Implementation

public class InMemoryCommandBus : ICommandBus
{
    private readonly Dictionary<Type, Func<ICommand, Task>> _handlers = new();

    public void RegisterHandler<TCommand>(Func<TCommand, Task> handler) where TCommand : ICommand
    {
        _handlers[typeof(TCommand)] = cmd => handler((TCommand)cmd);
    }

    public Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand
    {
        if (_handlers.TryGetValue(typeof(TCommand), out var handler))
            return handler(command);

        throw new Exception($"No handler registered for {typeof(TCommand).Name}");
    }
}

#endregion

#region Application Entry

class Program
{
    static async Task Main()
    {
        var commandBus = new InMemoryCommandBus();

        // Register handler
        commandBus.RegisterHandler<CreateOrderCommand>(
            async cmd => await new CreateOrderCommandHandler().HandleAsync(cmd)
        );

        // Simulate producing a command
        var command = new CreateOrderCommand
        {
            OrderId = Guid.NewGuid(),
            CustomerName = "John Doe"
        };

        Console.WriteLine("[Bus] Sending CreateOrderCommand...");
        await commandBus.SendAsync(command);
    }
}

#endregion