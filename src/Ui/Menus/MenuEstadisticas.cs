using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torneos.src.Ui.Menus
{
    public class MenuEstadisticas
    {
         public void Init()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Opciones();
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    MostrarError("Entrada Invalida");
                }
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        return;
                    default:
                        MostrarError("Opcion invalida");
                        break;
                }

            } while (opcion != 5);
        }

        public class LPL()
        {
            public void lpl(String texto, int velociadad = 5)
            {
                foreach (char letra in texto)
                {
                    Console.Write(letra);
                    Thread.Sleep(velociadad);
                }
                Console.WriteLine();
            }
        }
        public void Opciones()
        {
            LPL efecto = new LPL();
            efecto.lpl("╔══════════════════════════════════════════════════════════════════════╗");
            efecto.lpl("║                  📊 REPORTES Y ESTADÍSTICAS DE JUGADORES             ║");
            efecto.lpl("╠══════════════════════════════════════════════════════════════════════╣");
            efecto.lpl("║  1. Jugador con más asistencias a torneo                             ║");
            efecto.lpl("║  2. Equipos con más goles                                            ║");
            efecto.lpl("║  3. Jugadores más caros por equipo                                   ║");
            efecto.lpl("║  4. Jugadores por debajo del promedio de edad por equipo             ║");
            efecto.lpl("║  5. Salir al Menú Principal                                          ║");
            efecto.lpl("╚══════════════════════════════════════════════════════════════════════╝");



        }
        private void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[ERROR] {mensaje}");
            Console.ResetColor();
            Console.WriteLine("Presiona cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}