using System;

namespace EjemploThrow_A
{
    public static
        class ValidadorEdad
    {
        public static void validar(int edad){ 
            if(edad<18) 
                throw new ArithmeticException("Menor de edad");
        }
    }
}