using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverProject 
{
    public sealed class RoverObject : IDirection
    {   
        public static RoverObject Instance
        {
            get { return new RoverObject(); }
        }    

        private int _RoverIndex = 0;
        public int RoverIndex
        {
            get { return _RoverIndex; }
            set { _RoverIndex = value; }
        }

        private int _iCoordinateX = 0;
        public int iCoordinateX
        {
            get { return _iCoordinateX; }
            set { _iCoordinateX = value; }
        }

        private int _iCoordinateY = 0;
        public int iCoordinateY
        {
            get { return _iCoordinateY; }
            set { _iCoordinateY = value; }
        }

        public string CoordinateX
        {
            get { return (iCoordinateX).ToString(); }
        }

        public string CoordinateY
        {
            get { return (iCoordinateY).ToString(); }
        }

        private string _Commands;
        public string Commands
        {
            get { return _Commands; }
            set { _Commands = value; }
        }


        private IDirection _Direction = new DefaultDirection();
        public IDirection Direction
        {
            get { return _Direction; }
            set { _Direction = value; }
        }

        public void RotateLeft()
        {
            _Direction.RotateLeft();
        }

        public void RotateRight()
        {
            _Direction.RotateRight();
        }

        public void MoveForward()
        {
            _Direction.MoveForward();
        }
    }
}
