using System;
using System.Collections.Generic;
using System.Text;

namespace Mod18_L
{
    abstract class Audi
    {
        public virtual int speed()
        {
            return 200; //km/h
        }
    }

    class Audi2018 : Audi
    {
        public override int speed()
        {
            return 215;
        }
    }

    class Audi2019 : Audi
    {
        public override int speed()
        {
            return 250;
        }
    }
}
