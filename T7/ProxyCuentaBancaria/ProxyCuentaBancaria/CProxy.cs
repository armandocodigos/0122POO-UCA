using System;
using System.Collections.Generic;

namespace ProxyCuentaBancaria
{
    public class CProxy //Clase externa
    {
        public class Cajero : ISujeto //Clase interna pública
        {
            private CuentaBancaria cuenta;

            public object Peticion(int opcion, List<object> parametros)
            {
                if (cuenta == null)
                    cuenta = new CuentaBancaria();

                object resultado = null;
                switch (opcion)
                {
                    case 1://Consultar balance, input:void, output:double
                        resultado = cuenta.balance;
                        break;
                    case 2://Ingresar dinero, input:double, output:void
                        double monto = Convert.ToDouble(parametros[0]);
                        cuenta.balance += monto;
                        break;
                    case 3://Funcion extraña, input:bool, double, string
                        //output: bool
                        bool bandera = Convert.ToBoolean(parametros[0]);
                        double porce = Convert.ToDouble(parametros[1]);
                        string caden = Convert.ToString(parametros[2]);
                        if (bandera && porce < 0.1 && caden.StartsWith("A"))
                        {
                            cuenta.balance += 100;
                            resultado = true;
                        }
                        else
                        {
                            cuenta.balance -= 10;
                            resultado = false;
                        }
                        break;
                }
                return resultado;
            }
        }

        private class CuentaBancaria //Clase interna privada
        {
            public double balance { get; set; }
        }
    }
}