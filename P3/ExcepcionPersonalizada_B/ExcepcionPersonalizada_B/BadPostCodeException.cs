using System;

namespace ExcepcionPersonalizada_B
{
    public class BadPostCodeException : Exception 
    {
        // Constructor por defect
        public BadPostCodeException() : base() {
        
        }

        // Constructor con un mensaje (sirve para especificar la causa del error)
        public BadPostCodeException(string message) : base(message){
        
        }
    }
}