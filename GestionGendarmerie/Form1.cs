using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGendarmerie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Agent> liste = new List<Agent>(); 
        public void initialiser()
        {
            cb_code_a.SelectedIndex = -1;
            txt_nom.Clear();
            txt_adresse.Clear();
            dt_embauche.Value = DateTime.Today;
            lb_grade.SelectedIndex = -1;
            txt_code_c.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] grade = { "Capitaine", "lieutenant", "Officier", "Sous-Officier", "Soldat" };
            lb_grade.Items.AddRange(grade);
            btn_ajouter.Enabled = false;
            btn_modifier.Enabled = false;
            btn_supprimer.Enabled = false;
        }

        private void cb_code_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true; 
            }
        }

        private void cb_code_a_TextChanged(object sender, EventArgs e)
        {
            if (cb_code_a.Text != "")
            {
                btn_ajouter.Enabled = true;
                btn_modifier.Enabled = true;
                btn_supprimer.Enabled = true; 
            }
            else
            {
                btn_ajouter.Enabled = false;
                btn_modifier.Enabled = false;
                btn_supprimer.Enabled = false;
            }

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text != string.Empty && txt_adresse.Text != string.Empty && lb_grade.SelectedIndex != -1)
            {
                int code = int.Parse(cb_code_a.Text);
                string nom = txt_nom.Text;
                DateTime date = dt_embauche.Value;
                string grade = lb_grade.SelectedItem.ToString();
                string adresse = txt_adresse.Text;
                Agent a = new Agent(code, nom, adresse, grade, date);
                liste.Add(a);
                cb_code_a.Items.Add(code);
            }
            else MessageBox.Show("Veuillez remplir tout les champs ");
            initialiser();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text != string.Empty && txt_adresse.Text != string.Empty && lb_grade.SelectedIndex != -1)
            {
                bool exist = false;
                for(int i = 0; i<liste.Count;i++)
                {
                    if (liste[i].Code == int.Parse(cb_code_a.Text))
                    {
                        liste[i].Code = int.Parse(cb_code_a.Text);
                        liste[i].Nom = txt_nom.Text;
                        liste[i].Date = dt_embauche.Value;
                        liste[i].Grade = lb_grade.SelectedItem.ToString();
                        liste[i].Adresse = txt_adresse.Text;
                        exist = true;
                        break;
                    }           
                }
                if (exist == false) MessageBox.Show("Agent n'existe pas");
            }
            else MessageBox.Show("Veuillez remplir tout les champs ");
            initialiser();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
       
           foreach(Agent agt in liste)
            {
                if(agt.Code == int.Parse(cb_code_a.Text))
                {
                    cb_code_a.Items.Remove(agt.Code);
                    liste.Remove(agt);
                    break; 
                }

            }
           
        }

        private void lb_grade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            initialiser(); 
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            foreach(Agent agent in liste)
            {
                MessageBox.Show(agent.ToString()); 
            }
        }
    }
}
