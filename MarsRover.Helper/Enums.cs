using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Helper
{
    public class Enums
    {
        public enum ErrorTypes
        {
            InvalidInputForField = 1,
            InvalidInputForRover = 2,
            BoundaryOverflow = 3
        }

        public enum InputTypes
        {
            FieldCoordinateInput = 1,
            RoverCoordinateInput = 2,
            InstructionSetInput = 3
        }
    }
}
