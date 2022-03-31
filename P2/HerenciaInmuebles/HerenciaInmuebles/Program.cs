using System;

namespace HerenciaInmuebles
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
        }
    }
}