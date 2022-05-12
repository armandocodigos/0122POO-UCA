namespace TalleresGraficos
{
    public class Encuadernado
    {
        public string pegado { get; set; }
        public string empastado { get; set; }

        public Encuadernado(string pegado, string empastado)
        {
            this.pegado = pegado;
            this.empastado = empastado;
        }
    }
}