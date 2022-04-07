using System;

public class HelloWorld {
    static void Main() {
        Console.WriteLine("Bienvenido!");
        
        int contador_errores = 5;
        bool hayErrores = true;
        do{
            try {
    	        // Podría generar ArithmeticException
    	        Console.Write("\n\nNumerador: ");
    	        int num = Convert.ToInt32(Console.ReadLine());
    	        Console.Write("Denominador: ");
    	        int den = Convert.ToInt32(Console.ReadLine());
    	        int resultado = num / den;
    	        Console.WriteLine("Resultado: " + resultado);
    	        
    	        // Hemos llegado al final del bloque try
    	        Console.WriteLine("No hubo errores!");
    	        hayErrores = false;
    	    }
    	    catch(DivideByZeroException e) {
    	        Console.WriteLine("Error aritmético, división entre cero!");
    	        contador_errores--;
    	    }
    	    catch(IndexOutOfRangeException e) {
    	        Console.WriteLine("Indice erróneo, no existe esa casilla!");
    	        contador_errores--;
    	    }
    	    catch(Exception e) {
    	        Console.WriteLine("Error de otro tipo!");
    	        contador_errores--;
    	    }
        }while(hayErrores && contador_errores > 0);
        
        if(!hayErrores)
            Console.WriteLine("\nTenga un buen día!");
        else
            Console.WriteLine("\nPruebe más tarde :(");
    }
}
