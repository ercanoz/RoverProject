using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoverProject
{
    public partial class Form1 : Form
    {
        public static int iPlateauWidth;
        public static int iPlateauHeight;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (bParseInputValues() == false)
                return;

            MoveRover(xRoverObject1);
            MoveRover(xRoverObject2);
        }

        private void MoveRover(RoverObject prm_xRoverObject)
        {
            foreach (char c in prm_xRoverObject.Commands)
            {
                if (c == 'L')
                    prm_xRoverObject.RotateLeft();
                else if (c == 'R')
                    prm_xRoverObject.RotateRight();
                else if (c == 'M')
                    prm_xRoverObject.MoveForward();

                this.Invoke(new DelegateDrawRover(DrawRover), prm_xRoverObject);

                Thread.Sleep(500);
            }          
        }

        private delegate void DelegateDrawRover(RoverObject prm_xRoverObject);
        private void DrawRover(RoverObject prm_xRoverObject)
        {
            Label labelRoverX = this.Controls.Find("labelRoverX" + prm_xRoverObject.RoverIndex, true)[0] as Label;
            Label labelRoverY = this.Controls.Find("labelRoverY" + prm_xRoverObject.RoverIndex, true)[0] as Label;
            Label labelRoverDirection = this.Controls.Find("labelRoverDirection" + prm_xRoverObject.RoverIndex, true)[0] as Label;

            labelRoverX.Text = prm_xRoverObject.CoordinateX;
            labelRoverY.Text = prm_xRoverObject.CoordinateY;
            labelRoverDirection.Text = prm_xRoverObject.Direction.ToString();

            Application.DoEvents();
        }

        private bool bParseInputValues()
        {
            bool bReturnValue = false;

            try
            {
                if (txtInputValues.Lines.Count() < 5)
                    throw new Exception("Input Values Are Not TRUE");

                string[] strInputValues = txtInputValues.Lines;

                int.TryParse(strInputValues[0].Split(' ')[0], out iPlateauWidth);
                int.TryParse(strInputValues[0].Split(' ')[1], out iPlateauHeight);

                xRoverObject1 = GenerateRover(1, strInputValues[1], strInputValues[2]);
                xRoverObject2 = GenerateRover(2, strInputValues[3], strInputValues[4]);

                bReturnValue = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return bReturnValue;
        }

        private RoverObject GenerateRover(int prm_iRoverIndex, string prm_strInitialCoordinates, string prm_strCommands)
        {
            if (prm_strInitialCoordinates.Split(' ').Length != 3)
                throw new Exception(string.Format("Rover {0} Values Are Not TRUE", prm_iRoverIndex));

            int iRoverCoordinateX = 0;
            int iRoverCoordinateY = 0;

            int.TryParse(prm_strInitialCoordinates.Split(' ')[0], out iRoverCoordinateX);
            int.TryParse(prm_strInitialCoordinates.Split(' ')[1], out iRoverCoordinateY);

            if (iPlateauWidth < iRoverCoordinateX || iRoverCoordinateX < 0)
                throw new Exception(string.Format("Rover {0} Coordinate X Is Not TRUE", prm_iRoverIndex));

            if (iPlateauHeight < iRoverCoordinateY || iRoverCoordinateY < 0)
                throw new Exception(string.Format("Rover {0} Coordinate Y Is Not TRUE", prm_iRoverIndex));

            EnumDirection enumRoverDirection = (EnumDirection)Enum.Parse(typeof(EnumDirection), prm_strInitialCoordinates.Split(' ')[2]);

            var xRoverObject = RoverObject.Instance;
            xRoverObject.RoverIndex = prm_iRoverIndex;
            xRoverObject.iCoordinateX = iRoverCoordinateX;
            xRoverObject.iCoordinateY = iRoverCoordinateY;
            xRoverObject.Commands = prm_strCommands;
            xRoverObject.Direction = GetDirection(xRoverObject, enumRoverDirection);

            return xRoverObject;
        }

        private IDirection GetDirection(RoverObject xRoverObject, EnumDirection enumDirection)
        {
            Type type = enumDirection.GetType();

            MemberInfo[] memberInfo = type.GetMember(enumDirection.ToString());
            object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            Type xType = Type.GetType(string.Format("RoverProject.{0}", ((DescriptionAttribute)attrs[0]).Description));
            ConstructorInfo xConstructorInfo = xType.GetConstructor(new[] { typeof(RoverObject) });
            object xobject = xConstructorInfo.Invoke(new object[] { xRoverObject });

            return (IDirection)xobject;
        }
    }
}
