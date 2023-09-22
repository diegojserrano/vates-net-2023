namespace Quini6
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            Simulador simulador = new Simulador();
            simulador.GenerarApuesta();
            simulador.GenerarApuesta();
            simulador.GenerarApuesta();
            simulador.GenerarApuesta();
            simulador.GenerarApuesta();
            simulador.MostrarApuesta();
        }
    }
}