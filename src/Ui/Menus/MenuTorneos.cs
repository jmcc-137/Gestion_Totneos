using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torneos.Ui.Menus
{
    public class MenuTorneos
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
            efecto.lpl("╔════════════════════════════════╗");
            efecto.lpl("║      MENÚ DE TORNEOS           ║");
            efecto.lpl("╠════════════════════════════════╣");
            efecto.lpl("║ 1. ➕  Agregar Torneo          ║");
            efecto.lpl("║ 2. 🔍  Buscar Torneo           ║");
            efecto.lpl("║ 3. ❌  Eliminar Torneo         ║");
            efecto.lpl("║ 4. ✏️  Actualizar Torneo        ║");
            efecto.lpl("║ 5. 🔙  Volver al Menú Principal║");
            efecto.lpl("╚════════════════════════════════╝");

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