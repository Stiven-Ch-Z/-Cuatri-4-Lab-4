using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerMecanico.Models
{
    public class Auto
    {
        public string Placa { get; set; }//identificador de placa
        public string Marca { get; set; }//marca del auto
        public string Modelo { get; set; }//modelo del auto 
        public string NombreDueno { get; set; }//nombre del dueño del auto
        public DateTime FechaIngreso { get; set; }//fecha de ingreso del auto al taller
        public string Trabajo { get; set; }//trabajo solicitado para el auto
    }
}