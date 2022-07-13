using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gt
{
    public class Car<TEngine, TGearbox> //where TEngine : Engine//skoda fabia
    {
        int Seats;
        int Color;
        int roof;
        int wheels;
        int nadwozieVersion;
        //List<>
        TEngine engine;
    }
}
