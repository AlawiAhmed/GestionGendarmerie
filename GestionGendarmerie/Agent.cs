using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGendarmerie
{
    class Agent
    {
        int code;
        string nom, adresse, grade;
        DateTime Date_embauche; 

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }
        public DateTime Date
        {
            get { return Date_embauche; }
            set { Date_embauche = value;  }
        }
        public Agent() { }
        public Agent(int c , string n , string a , string g , DateTime dt)
        {
            code = c;
            adresse = a;
            nom = n;
            grade = g;
            Date_embauche = dt; 
        }
        public int CalculerAncienneté()
        {
            return DateTime.Today.Year - Date_embauche.Year;
        }
        public override string ToString()
        {
            return string.Format("_Agent_: Code : {0}, Nom : {1} - Adresse : {2} - Date d'Embauche : {3} - Grade : {4}", code, nom, adresse, Date_embauche, grade);
        }

    }
}
