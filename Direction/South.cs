using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverProject
{
    public class South : IDirection
    {
        private RoverObject _roverObject;

        public South(RoverObject roverObject)
        {
            _roverObject = roverObject;
        }

        public void MoveForward()
        {
            if(_roverObject.iCoordinateY > 0)
                _roverObject.iCoordinateY -= 1;
        }

        public void RotateLeft()
        {
            _roverObject.Direction = new East(_roverObject);
        }

        public void RotateRight()
        {
            _roverObject.Direction = new West(_roverObject);
        }
    }
}
