using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppJ.BL.Interfaces;

namespace WebAppJ.BL.Implementation
{
    public class JapanEngine : IEngine
    {
        public string ReleaseEngine()
        {
            return "Japan engine";
        }
    }
}
