using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Entities.Abstract
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        /// <summary>
        /// represents rover's starting position
        /// </summary>
        public Coordinate StartingPosition { get; set; }
        /// <summary>
        /// represents rover's current position
        /// </summary>
        public Coordinate CurrentPosition { get; set; }

        /// <summary>
        /// represents rover's starting direction
        /// </summary>
        public string StartingDirection { get; set; }
        /// <summary>
        /// represents rover's current direction
        /// </summary>
        public string CurrentDirection { get; set; }

    }
}
