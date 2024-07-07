using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG23
{
    /// <summary>
    /// Formulaire pour récupérer les informations des joueurs.
    /// </summary>
    public partial class Form1 : Form
    {
        private page1 page;
        private Joueur j;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Form1"/>.
        /// </summary>
        /// <param name="page">Instance de la page principale.</param>
        public Form1(page1 page)
        {
            InitializeComponent();
            this.page = page;
        }

        /// <summary>
        /// Gère l'événement Paint du panneau gunaPanel2.
        /// </summary>
        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {
            // Code pour gérer l'événement Paint de gunaPanel2
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour valider les informations des joueurs et passer au formulaire suivant.
        /// </summary>
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            // Vérifie que les champs pseudo ne sont pas vides
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Veuillez entrer le pseudo des deux joueurs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifie que les programmes ont été sélectionnés pour les deux joueurs
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir le programme des deux joueurs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crée un nouvel objet Joueur avec le pseudo et le programme sélectionné pour le premier joueur
            j = new Joueur(textBox1.Text, comboBox1.SelectedItem.ToString());
            if (j != null)
            {
                // Affiche la page3 et cache la page actuelle
                page3 page = new page3(this, j);
                page.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour revenir à la page principale.
        /// </summary>
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            page.Show();
            this.Close();
        }
    }
}
