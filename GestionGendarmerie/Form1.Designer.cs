namespace GestionGendarmerie
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_code_c = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.cb_code_a = new System.Windows.Forms.ComboBox();
            this.lb_grade = new System.Windows.Forms.ListBox();
            this.dt_embauche = new System.Windows.Forms.DateTimePicker();
            this.btn_vider = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_code_c
            // 
            this.txt_code_c.Location = new System.Drawing.Point(386, 35);
            this.txt_code_c.Name = "txt_code_c";
            this.txt_code_c.Size = new System.Drawing.Size(163, 20);
            this.txt_code_c.TabIndex = 0;
            this.txt_code_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_code_a_KeyPress);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(111, 127);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(163, 20);
            this.txt_nom.TabIndex = 1;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(111, 169);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(163, 20);
            this.txt_adresse.TabIndex = 2;
            // 
            // cb_code_a
            // 
            this.cb_code_a.FormattingEnabled = true;
            this.cb_code_a.Location = new System.Drawing.Point(111, 34);
            this.cb_code_a.Name = "cb_code_a";
            this.cb_code_a.Size = new System.Drawing.Size(163, 21);
            this.cb_code_a.TabIndex = 3;
            this.cb_code_a.TextChanged += new System.EventHandler(this.cb_code_a_TextChanged);
            this.cb_code_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_code_a_KeyPress);
            // 
            // lb_grade
            // 
            this.lb_grade.FormattingEnabled = true;
            this.lb_grade.Location = new System.Drawing.Point(386, 86);
            this.lb_grade.Name = "lb_grade";
            this.lb_grade.Size = new System.Drawing.Size(120, 95);
            this.lb_grade.TabIndex = 4;
            this.lb_grade.SelectedIndexChanged += new System.EventHandler(this.lb_grade_SelectedIndexChanged);
            // 
            // dt_embauche
            // 
            this.dt_embauche.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_embauche.Location = new System.Drawing.Point(111, 86);
            this.dt_embauche.Name = "dt_embauche";
            this.dt_embauche.Size = new System.Drawing.Size(163, 20);
            this.dt_embauche.TabIndex = 5;
            // 
            // btn_vider
            // 
            this.btn_vider.Location = new System.Drawing.Point(60, 223);
            this.btn_vider.Name = "btn_vider";
            this.btn_vider.Size = new System.Drawing.Size(75, 23);
            this.btn_vider.TabIndex = 6;
            this.btn_vider.Text = "Vider ";
            this.btn_vider.UseVisualStyleBackColor = true;
            this.btn_vider.Click += new System.EventHandler(this.btn_vider_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(166, 223);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 7;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(272, 223);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 8;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(386, 223);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 9;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_afficher
            // 
            this.btn_afficher.Location = new System.Drawing.Point(493, 223);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(75, 23);
            this.btn_afficher.TabIndex = 10;
            this.btn_afficher.Text = "Afficher";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Code Agent : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Grade: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Code Capitaine : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adresse : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nom : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date Embauche : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_afficher);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_vider);
            this.Controls.Add(this.dt_embauche);
            this.Controls.Add(this.lb_grade);
            this.Controls.Add(this.cb_code_a);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_code_c);
            this.Name = "Form1";
            this.Text = "Gestion Agent Gendarme ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_code_c;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.ComboBox cb_code_a;
        private System.Windows.Forms.ListBox lb_grade;
        private System.Windows.Forms.DateTimePicker dt_embauche;
        private System.Windows.Forms.Button btn_vider;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

