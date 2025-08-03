using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torneos.src.Modules.Personas.Domain.Entities
{
    public class Torneo
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }

        public DateTime Ifecha { get; set; }
        public DateTime Ffecha { get; set; }

        public List<Equipo> equipos { get; set; } = new List<Equipo>();

        public List<Torneo> torneos { get; set; } = new List<Torneo>();

        public Torneo(int id, string? nombre, string? ciudad, string? pais, DateTime ifecha, DateTime ffecha)
        {
            Id = id;
            Nombre = nombre;
            Pais = pais;
            Ciudad = ciudad;
            Ifecha = ifecha;
            Ffecha = ffecha;
        }
        public Torneo() { }

        public override string ToString()
        {
            return $"ID:{Id}, Nombre:{Nombre}, Pais:{Pais}, Ciudad:{Ciudad}, Fecha de inicio{Ifecha}, Fecha final:{Ffecha}";
        }
    }
}