using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPlateformMIAGE.Models
{
    public class Devoir
    {
        private string date;
        private Module leModule;

        public Devoir(string date)
        {
            this.date = date;
        }

        public string Date { get => date; set => date = value; }
    }
}