using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Kiosco(){
        }
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {   Conversor c = new Conversor();

            Double pesos = c.ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        
    }
}