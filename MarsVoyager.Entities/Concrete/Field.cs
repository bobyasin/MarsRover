using MarsRover.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Entities.Concrete
{
    public class Field
    {
        public Coordinate Boundaries { get; set; }

        public Field()
        {
            this.Boundaries = new Coordinate();
        }


    }
}

