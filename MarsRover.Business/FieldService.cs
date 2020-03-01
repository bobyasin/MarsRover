using MarsRover.Entities.Abstract;
using MarsRover.Entities.Concrete;
using MarsRover.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business
{
    public class FieldService : IFieldService
    {
        public Field CreateField()
        {
            var field = new Field();
            AskForInitialCoordinates(field, MessageHelper.GetInputMessageText(Enums.InputTypes.FieldCoordinateInput));
            return field;
        }

        public void AskForInitialCoordinates(Field field, string message)
        {
            Console.WriteLine(message);

            var input = Console.ReadLine();
            while (ValidateCoordinateInput(input) == null)
            {
                Console.WriteLine("Please enter valid input for initial coordinates");
                input = Console.ReadLine();
            }

            var coordinates = input.Split(" ");
            field.Boundaries.PositionX = Convert.ToInt32(coordinates[0]);
            field.Boundaries.PositionY = Convert.ToInt32(coordinates[1]);

        }


        public void AssignCoordinates(ref Coordinate c, string str)
        {
            while (ValidateCoordinateInput(str) == null)
            {
                Console.WriteLine("Please enter valid input for initial coordinates");
                str = Console.ReadLine();
            }
            var coordinates = str.Split(" ");
            // c = new CoordinateInfo(Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1]));
        }

        private string[] ValidateCoordinateInput(string str, bool isRobot = false)
        {
            var coordinates = str.Trim().Split(' ');

            int x = -1;
            int y = -1;

            var flag = coordinates.Length == 2
                && int.TryParse(coordinates[0], out x)
                && int.TryParse(coordinates[1], out y)
                && x > 0 && y > 0;


            return flag ? coordinates : null;
        }
    }
}
