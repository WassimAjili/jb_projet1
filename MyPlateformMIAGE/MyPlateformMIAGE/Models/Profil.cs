﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPlateformMIAGE.Models
{
    public class Profil
    {
        private string nom, dateNaiss, prenom, courriel, id, mdp, telephone;

        public Profil(string nom, string dateNaiss, string prenom, string courriel, string id, string mdp, string telephone)
        {
            this.nom = nom;
            this.dateNaiss = dateNaiss;
            this.prenom = prenom;
            this.courriel = courriel;
            this.id = id;
            this.mdp = mdp;
            this.telephone = telephone;
        }

        public string Nom { get => nom; set => nom = value; }
        public string DateNaiss { get => dateNaiss; set => dateNaiss = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Courriel { get => courriel; set => courriel = value; }
        public string Id { get => id; set => id = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Telephone { get => telephone; set => telephone = value; }
    }
}