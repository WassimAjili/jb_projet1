﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPlateformMIAGE.Models
{
    public class ExamenLocal : Examen
    {
        private Etablissement etablissement;
        public ExamenLocal(string date, string lieu, double noteEF) : base(date, lieu, noteEF)
        {

        }
    }
}