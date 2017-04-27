using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPlateformMIAGE.Models
{
    public class Module
    {
        private string nom;
        private double coeff, noteCC;
        private bool estNational;
        private List<Apprenant> lesApprenants;
        private TuteurEnseignant ens;
        private SessionRegroupement sr;
        private List<Devoir> lesDevoirs;
        private List<Examen> lesExamens;
        private List<Semestre> lesSemestres;

        public Module(string nom, double coeff, Boolean estNational, double noteCC)
        {
            this.nom = nom;
            this.coeff = coeff;
            this.noteCC = noteCC;
            this.estNational = estNational;
        }

        public string Nom { get => nom; set => nom = value; }
        public double Coeff { get => coeff; set => coeff = value; }
        public double NoteCC { get => noteCC; set => noteCC = value; }
        public bool EstNational { get => estNational; set => estNational = value; }

    }
}