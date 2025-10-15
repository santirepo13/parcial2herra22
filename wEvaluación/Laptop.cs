using System;

namespace wEvaluacion
{
    public class Laptop : Dispositivo
    {


        //se le añade override al metodo para que sobreescriba el metodo de la clase padre en vez de new
        //como se habia hecho inicialmente
        public override double CalcularMantenimiento()
        {
            return CostoBase * 0.15;
        }







    }
}
