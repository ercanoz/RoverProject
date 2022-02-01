using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverProject
{
    public interface IDirection
    {
        void RotateLeft();

        void RotateRight();

        void MoveForward();
    }
}
