using System;
using System.Collections.Generic;
using System.Text;
using static MarsRover.Helper.Enums;

namespace MarsRover.Helper
{
    public static class MessageHelper
    {
        public static string GetErrorMessageText(ErrorTypes errorType)
        {
            switch (errorType)
            {
                case ErrorTypes.InvalidInputForRover:
                    return TextMessages.ERR_0001;

                case ErrorTypes.InvalidInputForField:
                    return TextMessages.ERR_0002;

                case ErrorTypes.BoundaryOverflow:
                    return TextMessages.ERR_RANGE_OVERFLOW;
                default:
                    return "";
            }
        }

        public static string GetInputMessageText(InputTypes inputType)
        {
            switch (inputType)
            {
                case InputTypes.FieldCoordinateInput:
                    return TextMessages.TXT_BOUNDARY;

                case InputTypes.RoverCoordinateInput:
                    return TextMessages.TXT_INIT_COORDS;

                case InputTypes.InstructionSetInput:
                    return TextMessages.TXT_INST_SET;

                default:
                    return "";
            }
        }
    }
}
