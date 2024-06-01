using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Estadio
{
    internal class Precios_Partidos
    {
        public string Zona { get; set; }
        public string Precios_Adultos { get; set; }
        public string Precios_Niños { get; set; }
        public string Precios_Discapacitados { get; set; }

        public Precios_Partidos(string Zona, string Precios_Adultos, string Precios_Niños, string Precios_Discapacitados)
        {
            this.Zona = Zona;
            this.Precios_Adultos = Precios_Adultos;
            this.Precios_Niños = Precios_Niños;
            this.Precios_Discapacitados = Precios_Discapacitados;
        }
    }
}
