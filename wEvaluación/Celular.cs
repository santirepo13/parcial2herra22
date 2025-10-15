using System;

namespace wEvaluacion
{
    public class Celular : Dispositivo
    {
                //override en vez de new para sobreescribir el metodo de la clase padre

        public override double CalcularMantenimiento()
        {
            return 100000;
        }


    }
}