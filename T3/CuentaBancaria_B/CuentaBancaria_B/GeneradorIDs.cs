namespace CuentaBancaria_B
{
    public static class GeneradorIDs
    {
        // Atributo
        private static int contador = 0;
    
        // Métodos estáticos
        public static int nuevoID() {
            contador++;
            return contador;
        }
    }
}