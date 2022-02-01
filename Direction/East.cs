using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverProject
{
    public class East : IDirection
    {
        private RoverObject _roverObject;

        public East(RoverObject roverObject)
        {
            _roverObject = roverObject;
        }

        public void MoveForward()
        {
            if (_roverObject.iCoordinateX < Form1.iPlateauWidth)
                _roverObject.iCoordinateX += 1;
        }

        public void RotateLeft()
        {
            _roverObject.Direction = new North(_roverObject);
        }

        public void RotateRight()
        {
            _roverObject.Direction = new South(_roverObject);
        }
    }
}
