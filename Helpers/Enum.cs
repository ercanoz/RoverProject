using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverProject
{
    public enum EnumDirection
    {
        [Description("East")]
        E = 0,
        [Description("West")]
        W,
        [Description("North")]
        N,
        [Description("South")]
        S
    }
}
