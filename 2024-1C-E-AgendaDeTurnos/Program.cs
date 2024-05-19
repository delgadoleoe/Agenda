
namespace _2024_1C_E_AgendaDeTurnos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = Startup.InicializarApp(args); //Pasamos los argumentos que son recibidos en la ejecucion

            app.Run();
        }
    }
}