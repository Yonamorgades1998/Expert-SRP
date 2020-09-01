using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
         //Cumple con el patros SRP
         
         // Esta clase cumple con el principio expert ya que conoce toda la información de Alfajor y todas sus funcionalidades        Esta clase cumple con el principio expert ya que conoce toda la informacion de Alfajor y todas sus funcionalidades
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}