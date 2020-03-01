using MarsRover.Business;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRover.App
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();

            var fieldService = _serviceProvider.GetService<IFieldService>();

            var field = fieldService.CreateField();

            var roverService = _serviceProvider.GetService<IRoverService>();

            var rover1 = roverService.CreateMarsRover(field.Boundaries);
            var rover2 = roverService.CreateMarsRover(field.Boundaries);

            roverService.MakeMovement(rover1);
            roverService.MakeMovement(rover2);

            roverService.WriteRoverCurrentPosition(rover1);
            roverService.WriteRoverCurrentPosition(rover2);

            DisposeServices();
            Console.ReadLine();
        }



        private static void RegisterServices()
        {
            _serviceProvider = new ServiceCollection()
                .AddSingleton<IFieldService, FieldService>()
                .AddSingleton<IRoverService, RoverService>()
                .BuildServiceProvider();
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
