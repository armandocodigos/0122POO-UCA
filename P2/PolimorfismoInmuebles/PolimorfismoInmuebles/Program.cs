using System;

namespace PolimorfismoInmuebles
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Inmueble unInmueble = new Inmueble();
            unInmueble.direccion = "San Miguel";
            unInmueble.area = 150.0;
        
            LocalComercial unLocal = new LocalComercial();
            unLocal.direccion = "Santa Ana";
            unLocal.area = 100.0;
            unLocal.nombreNegocio = "Venta de comida";
        
            RanchoPlaya unRancho = new RanchoPlaya();
            unRancho.direccion = "San Blas";
            unRancho.area = 250.0;
            unRancho.cantidadPiscinas = 2;
        
            Hospital unHospital = new Hospital();
            unHospital.direccion = "San Salvador";
            unHospital.area = 1000.0;
            unHospital.cantidadCamas = 2000;
        
            mostrarDatos(unInmueble);
            mostrarDatos(unLocal);
            mostrarDatos(unRancho);
            mostrarDatos(unHospital);
        }
        
        /* Este método funcionará para Inmueble y para TODAS SUS SUB-CLASES 
       ¡Es genial verdad! ¿Pero cuál es el costo/restricción?
       Sólo tendrá acceso a los atributos de la clase padre (Inmueble)
       No podrá utilizar nombreNegocio, cantidadPiscinas ni cantidadCamas
       porque dichos atributos son específicos de cada sub-clase */
        public static void mostrarDatos(Inmueble unInmueble) {
            Console.WriteLine("------Datos------");
            Console.WriteLine("Dirección: " + unInmueble.direccion);
            Console.WriteLine("Area: " + unInmueble.area + " metros cuadrados\n");
        }
    }
}