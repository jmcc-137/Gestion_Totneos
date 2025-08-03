using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torneos.src.Modules.Personas.Domain.Entities
{
    public class Tecnico
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
    }
}