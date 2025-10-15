using System;

namespace wEvaluacion
{
    public class Dispositivo
    {
        public string Nombre { get; set; }
        public double CostoBase { get; set; }


        //dejamos un metodo virtual para que las clases hijas lo sobreescriban, además eliminamos el 
        //segundo metodo que no era necesario porque en el form no se pide el extra.


        public virtual double CalcularMantenimiento()
        {
            return CostoBase * 0.10;
        }




    

    }
}







