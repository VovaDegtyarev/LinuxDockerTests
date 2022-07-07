using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppJ.BL.Interfaces
{
    public interface IFactory
    {
        IEngine CreateEngine();
        ICar CreateCar();
    }
}
