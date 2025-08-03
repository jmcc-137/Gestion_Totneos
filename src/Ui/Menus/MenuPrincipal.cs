using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Torneos.src.Ui.Menus;
using Torneos.Ui.Menus;
namespace Torneos.Ui.Menus.MenuPrincipal
{

    public class MenuPrincipal : IMenu
    {
        public void Init()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Encabezado();
                Opciones();
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    MostrarError("Entrada invalida");
                }

                switch (opcion)
                    {
                        case 0:
                        MenuTorneos torneos = new MenuTorneos();
                        torneos.Init();
                            break;
                        case 1:
                        MenuEquipos equipos = new MenuEquipos();
                        equipos.Init();
                            break;
                        case 2:
                        MenuJugadores jugadores = new MenuJugadores();
                        jugadores.Init();
                            break;
                        case 3:
                        MenuTransferencias transferencias = new MenuTransferencias();
                        transferencias.Init();
                            break;
                        case 4:
                        MenuEstadisticas estadisticas = new MenuEstadisticas();
                        estadisticas.Init();
                            break;
                        case 5:
                            return;
                        default:
                            MostrarError("opcion invalida");
                            break;
                    }

            } while (opcion != 5);


        }
        private void Encabezado()
        {
            LPL efecto = new LPL();
            Console.ForegroundColor = ConsoleColor.Cyan;
            efecto.lpl("╔════════════════════════════════════╗");
            efecto.lpl("║      ⚽  SISTEMA DE TORNEOS ⚽     ║");
            efecto.lpl("╚════════════════════════════════════╝");
            Console.ResetColor();

        }
        private void Opciones()
        {
            LPL efecto = new LPL();
            efecto.lpl("0. 🏆  Crear Torneo");
            efecto.lpl("1. 🛡️  Registro de Equipos");
            efecto.lpl("2. 👟  Registro de Jugadores");
            efecto.lpl("3. 💰  Transferencias (Compra, Préstamo)");
            efecto.lpl("4. 📊  Estadísticas");
            efecto.lpl("5. ❌  Salir");
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

    public class LPL()
    {
        public void lpl(String texto, int velociadad = 10)
        {
            foreach (char letra in texto)
            {
                Console.Write(letra);
                Thread.Sleep(velociadad);
            }
            Console.WriteLine();
        }


    }
}

