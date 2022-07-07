using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppJ.BL.Interfaces;

namespace WebAppJ.BL.Implementation
{
    public class RussianFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new RussianCar();
        }

        public IEngine CreateEngine()
        {
            return new RussianEngine();
        }
    }
}
