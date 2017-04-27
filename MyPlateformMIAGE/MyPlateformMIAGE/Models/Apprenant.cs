using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPlateformMIAGE.Models
{
    public class Apprenant : Profil
    {
        private string dateInscription;
        private List<Module> lesModules;
        public Apprenant(string nom, string dateNaiss, string prenom, string courriel, string id, string mdp, string telephone, string dateInscription) : base (nom, dateNaiss, prenom, courriel, id, mdp, telephone)
        {
            this.dateInscription = dateInscription;
        }

        public string DateInscription { get => dateInscription; set => dateInscription = value; }

        public Boolean aRendu(Devoir d)
        {
            return false;
        }

        public void modifierInfos()
        {

        }
    }
}