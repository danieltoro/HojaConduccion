﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HojaConduccion.Models
{
    public class ManiobraModel
    {
        public int ManiobraID { get; set; }

        public int Tren { get; set; }

        public int CocheP { get; set; }

        public int Radio { get; set; }

        public string LugarIni { get; set; }

        public DateTime HoraIni { get; set; }

        public DateTime HoraFin { get; set; }

        public string LugarFin { get; set; }



    }
}