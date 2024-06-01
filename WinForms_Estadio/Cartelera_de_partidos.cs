using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Estadio
{
    internal class Cartelera_de_partidos
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string juegan { get; set; }
        public string Tipo_de_partido { get; set; }
        public string Lugar { get; set; }
        public string Entradas_Disponibles { get; set; }

        public Cartelera_de_partidos(string fecha, string hora, string juegan, string tipopartido, string lugar, string entradasdis)
        {
            this.Fecha = fecha;
            this.Hora = hora;
            this.juegan = juegan;
            this.Tipo_de_partido = tipopartido;
            this.Lugar = lugar;
            this.Entradas_Disponibles = entradasdis;
        }

    }
}
