using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppJ.BL.Interfaces;

namespace WebAppJ.BL.Implementation
{
    public class JapanFactory : IFactory
    {
        public ICar CreateCar()
        {
            return new JapanCar();
        }

        public IEngine CreateEngine()
        {
            return new JapanEngine();
        }
    }
}
