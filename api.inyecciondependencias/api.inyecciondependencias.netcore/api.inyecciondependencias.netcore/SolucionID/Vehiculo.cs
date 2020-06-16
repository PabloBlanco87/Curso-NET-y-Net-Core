using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.inyecciondependencias.netcore.SolucionID
{
    
    public class Vehiculo
    {

        protected IMotor _motor;

        public Vehiculo(IMotor motor)
        {
            _motor = motor;
        }

        public string Arrancar()
        {
            return _motor.Arrancar();
        }
    }
}
