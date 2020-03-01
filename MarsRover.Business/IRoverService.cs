using MarsRover.Entities.Abstract;
using MarsRover.Entities.Concrete;


namespace MarsRover.Business
{
    public interface IRoverService
    {
        /// <summary>
        /// simulates a step of instruction set for rover 
        /// </summary>
        void MakeMovement(Rover rover);

        /// <summary>
        /// creates a new rover 
        /// </summary>
        Rover CreateMarsRover(Coordinate maxRange);

        void WriteRoverCurrentPosition(Rover rover);
    }
}
