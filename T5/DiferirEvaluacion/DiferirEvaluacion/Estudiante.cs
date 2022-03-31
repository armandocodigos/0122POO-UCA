namespace DiferirEvaluación
{
    public class Estudiante
    {
        public string nombre{ get; set; }
        public string carné{ get; set; }
        public string carrera{ get; set; }
    
        public Estudiante(string nombre, string carné, string carrera)
        {
            this.nombre = nombre;
            this.carné = carné;
            this.carrera = carrera;
        }
    }
}