using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Entities.Abstract
{
    public class Coordinate
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Coordinate()
        {

        }

        public Coordinate(int x, int y)
        {
            this.PositionX = x;
            this.PositionY = y;
        }
    }
}
