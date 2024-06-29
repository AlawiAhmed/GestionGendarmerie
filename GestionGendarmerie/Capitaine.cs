using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGendarmerie
{
    class Capitaine : Agent
    {
        List<Agent> liste_agents; 

        public List<Agent> L_Agents
        {
            get { return liste_agents; }
            set { liste_agents = value; }
        }
        public Capitaine() : base()
        {

        }
        public Capitaine(int code , string nom , string adresse , string grade , DateTime date, List<Agent> la) : base(code, nom, adresse, grade, date)
        {
            this.liste_agents = la; 
        }
        public override string ToString()
        {
            string s = "";
            foreach(Agent a in liste_agents)
            {
                s += a.ToString() + ",";
            }

            return base.ToString() + s;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
           if (!(obj is Capitaine)) return false;
            if (this.Code == ((Capitaine)obj).Code) return true;
            else return false;
        }
    }
}
