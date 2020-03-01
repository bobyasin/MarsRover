
using MarsRover.Entities.Abstract;
using System;


namespace MarsRover.Entities.Concrete
{
    public class Rover : Vehicle
    {
        public string InstructionSet { get; set; }
        public int DirectionKey { get; set; }
        public Rover(int id)
        {
            this.Id = id;

            this.CurrentPosition = new Coordinate();
        }

    }
}
