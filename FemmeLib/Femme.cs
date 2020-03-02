using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FemmeLib
{
    public class Femme
    {
        #region VARIABLES MEMBRES
        private string _nom;
        private string _prenom;
        private DateTime _naissance;
        private string _description;
        #endregion

        #region PROPRIETES
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public DateTime Naissance
        {
            get { return _naissance; }
            set { _naissance = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        #endregion

        #region CONSTRUCTEURS
        public Femme(string nom, string prenom, DateTime naissance, string description)
        {
            Nom = nom;
            Prenom = prenom;
            Naissance = naissance;
            Description = description;
        }

        public Femme() : this("Noémie", "Peppels", new DateTime(1999, 02, 16), "Femme par défaut")
        {

        }
        #endregion

        #region METHODES
        public override string ToString()
        {
            return Prenom + " " + Nom + " " + Naissance.Day + "/" + Naissance.Month + "/" + Naissance.Year + " " + Description;
        }
        #endregion
    }
}
