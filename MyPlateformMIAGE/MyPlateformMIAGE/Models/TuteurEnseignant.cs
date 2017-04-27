using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPlateformMIAGE.Models
{
    public class TuteurEnseignant : Profil
    {
        private List<Module> lesModules;

        public TuteurEnseignant(string nom, string dateNaiss, string prenom, string courriel, string id, string mdp, string telephone) : base (nom, dateNaiss, prenom, courriel, id, mdp, telephone)
        {

        }

        public void consulterInfoApprenant(Apprenant a)
        {

        }

        public void verifierRenduDevoir(Apprenant a, Devoir d)
        {

        }
    }
}