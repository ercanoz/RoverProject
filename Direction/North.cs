using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverProject
{
    public class North : IDirection
    {
        private RoverObject _roverObject;

        public North(RoverObject roverObject)
        {
            _roverObject = roverObject;
        }

        public void MoveForward()
        {
            if(_roverObject.iCoordinateY < Form1.iPlateauHeight)
                _roverObject.iCoordinateY += 1;
        }

        public void RotateLeft()
        {
            _roverObject.Direction = new West(_roverObject);
        }

        public void RotateRight()
        {
            _roverObject.Direction = new East(_roverObject);
        }

    }
}
