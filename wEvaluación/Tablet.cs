using System;

namespace wEvaluacion
{
    public class Tablet : Dispositivo
    {
        //override en vez de new para sobreescribir el metodo de la clase padre
        public override double CalcularMantenimiento()
        {
            return (CostoBase * 0.05);
        }

      
    }
}