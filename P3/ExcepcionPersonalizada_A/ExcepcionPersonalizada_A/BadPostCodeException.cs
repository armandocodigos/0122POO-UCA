using System;

namespace ExcepcionPersonalizada_A
{
    public class BadPostCodeException : Exception 
    {
        // Constructor por defecto
        public BadPostCodeException() : base() {
        
        }

        // Constructor con un mensaje (sirve para especificar la causa del error)
        public BadPostCodeException(string message) : base(message){
        
        }
    }
}