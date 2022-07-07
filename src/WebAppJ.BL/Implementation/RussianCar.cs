using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppJ.BL.Interfaces;

namespace WebAppJ.BL.Implementation
{
    public class RussianCar : ICar
    {
        public string ReleaseCar(IEngine engine)
        {
            var a = "Released Russian Car";
            var s = engine.ReleaseEngine();

            return s + "   " + a;
        }
    }
}
