using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverProject
{
    public class West : IDirection
    {
        private RoverObject _roverObject;

        public West(RoverObject roverObject)
        {
            _roverObject = roverObject;
        }

        public void MoveForward()
        {
            if(_roverObject.iCoordinateX > 0)
                _roverObject.iCoordinateX -= 1;
        }

        public void RotateLeft()
        {
            _roverObject.Direction = new South(_roverObject);
        }

        public void RotateRight()
        {
            _roverObject.Direction = new North(_roverObject);
        }
    }
}
