using MarsRover.Entities.Abstract;
using MarsRover.Entities.Concrete;
using MarsRover.Helper;
using System;

namespace MarsRover.Business
{
    public class RoverService : IRoverService
    {
        private const string _allowedMoves = "LlRrMm";
        private const string _directions = "NnEeSsWw";

        private int _roverIdCounter = 0;
        private Coordinate _maxRange;
        public Rover CreateMarsRover(Coordinate maxRange)
        {
            var newRover = new Rover(++_roverIdCounter);
            _maxRange = maxRange;

            AskForInitialCoordinates(newRover,
                MessageHelper.GetInputMessageText(Enums.InputTypes.RoverCoordinateInput).Replace("[ID]", newRover.Id.ToString()));

            AskForInstructions(newRover,
                MessageHelper.GetInputMessageText(Enums.InputTypes.InstructionSetInput).Replace("[ID]", newRover.Id.ToString()));

            return newRover;

        }

        private void AskForInitialCoordinates(Rover newRover, string message)
        {
            Console.WriteLine(message);

            var input = Console.ReadLine();
            while (ValidateCoordinateInput(input) == null)
            {
                Console.WriteLine(MessageHelper.GetErrorMessageText(Enums.ErrorTypes.InvalidInputForRover));
                input = Console.ReadLine();
            }

            var coordinates = input.Split(" ");
            newRover.StartingPosition = new Coordinate(Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1]));
            newRover.CurrentPosition = new Coordinate(Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1]));
            newRover.StartingDirection = coordinates[2].ToUpper();
            newRover.CurrentDirection = coordinates[2].ToUpper();
            newRover.DirectionKey = AssignDirection(newRover.CurrentDirection);
        }

        public string[] ValidateCoordinateInput(string str)
        {
            var coordinates = str.Trim().Split(' ');

            int x = -1;
            int y = -1;

            var flag = coordinates.Length == 3
                && int.TryParse(coordinates[0], out x)
                && int.TryParse(coordinates[1], out y)
                && x > 0 && y > 0
                && _directions.Contains(coordinates[2]);

            if (x > _maxRange.PositionX || y > _maxRange.PositionY)
            {
                Console.WriteLine(MessageHelper.GetErrorMessageText(Enums.ErrorTypes.BoundaryOverflow));
                return null;
            }
            return flag ? coordinates : null;
        }

        private void AskForInstructions(Rover newRover, string message)
        {
            Console.WriteLine(message);

            var instructionSetInput = ValidateInstructionSet(Console.ReadLine());

            while (string.IsNullOrEmpty(instructionSetInput))
            {
                Console.WriteLine(MessageHelper.GetErrorMessageText(Enums.ErrorTypes.InvalidInputForRover));
                instructionSetInput = ValidateInstructionSet(Console.ReadLine());
            }

            newRover.InstructionSet = instructionSetInput;
        }

        private string ValidateInstructionSet(string instructionSetInput)
        {
            if (string.IsNullOrEmpty(instructionSetInput))
                return "";

            var filteredInstructionSet = "";

            foreach (var move in instructionSetInput)
            {
                filteredInstructionSet += _allowedMoves.Contains(move) ? move.ToString() : "";
            }

            return filteredInstructionSet.ToUpper();
        }

        /// <summary>
        /// Making moves for rover
        /// L: -1 (decreases 1)
        /// R: +1 (increases 1)
        ///
        /// North: 0
        /// East:  1
        /// South: 2
        /// West:  3
        /// values by mod for directions
        /// </summary>
        public void MakeMovement(Rover rover)
        {
            foreach (var step in rover.InstructionSet)
            {
                switch (step)
                {
                    case 'L':
                        rover.DirectionKey -= 1;
                        break;

                    case 'R':
                        rover.DirectionKey += 1;
                        break;

                    case 'M':
                        // take a step
                        rover.DirectionKey = rover.DirectionKey < 0 ? rover.DirectionKey += 4 : rover.DirectionKey;
                        rover.DirectionKey = rover.DirectionKey % 4;

                        switch (rover.DirectionKey)
                        {
                            case 0://N
                                // y++
                                rover.CurrentPosition.PositionY += 1;
                                break;

                            case 1://E
                                   // x++
                                rover.CurrentPosition.PositionX += 1;
                                break;

                            case 2://S
                                   //y--
                                rover.CurrentPosition.PositionY -= 1;
                                break;

                            case 3://W
                                // x--
                                rover.CurrentPosition.PositionX -= 1;
                                break;
                        }

                        break;
                }
            }

            rover.CurrentDirection = AssignDirection(rover.DirectionKey);
        }

        private string AssignDirection(int directionKey)
        {
            string direction = "";
            switch (directionKey)
            {
                case 0:
                    direction = "N";
                    break;

                case 1:
                    direction = "E";
                    break;

                case 2:
                    direction = "S";
                    break;

                case 3:
                    direction = "W";
                    break;
            }
            return direction;
        }

        private int AssignDirection(string direction)
        {
            int directionKey = 0;
            switch (direction)
            {
                case "N":
                case "n":
                    directionKey = 0;
                    break;

                case "E":
                case "e":
                    directionKey = 1;
                    break;

                case "S":
                case "s":
                    directionKey = 2;
                    break;

                case "W":
                case "w":
                    directionKey = 3;
                    break;
            }

            return directionKey;
        }

        private bool CheckRoverFinalPosition(Rover rover)
        {
            return !(rover.CurrentPosition.PositionX > _maxRange.PositionX || rover.CurrentPosition.PositionY > _maxRange.PositionY);
        }

        public void WriteRoverCurrentPosition(Rover rover)
        {
            var checkResult = CheckRoverFinalPosition(rover);
            if (!checkResult)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine("rover{0} : {1} {2}", rover.Id, rover.CurrentPosition.PositionX + " "
                       + rover.CurrentPosition.PositionY + " " + rover.CurrentDirection, (!checkResult ? "--- rover has overflowed the boundaries " : ""));


            Console.ResetColor();
        }
    }

}
