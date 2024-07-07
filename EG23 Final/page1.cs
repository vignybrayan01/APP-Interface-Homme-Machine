using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG23
{
    /// <summary>
    /// Représente la fenêtre principale d'entrée du programme.
    /// Cette fenêtre contient les boutons pour démarrer un nouveau jeu, charger un jeu existant, etc.
    /// </summary>
    public partial class page1 : Form
    {
        public object Private { get; private set; }

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="page1"/>.
        /// </summary>
        public page1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour afficher la description du jeu.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.BackgroundImage = null;
            Label descriptionlLabel = new Label();
            descriptionlLabel.Text = "Description du jeu :\n\nVoici un jeu captivant où vous pouvez explorer des \nmondes fantastiques et relever des défis incroyables.";
            descriptionlLabel.AutoSize = true;
            descriptionlLabel.Location = new Point(10, 10);
            descriptionlLabel.Font = new Font("Arial", 12);
            panel2.Controls.Add(descriptionlLabel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Code pour gérer l'événement Click du bouton5
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour fermer le jeu.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez vous vraiment fermer le jeu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour afficher une description détaillée du jeu.
        /// </summary>
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.BackgroundImage = null;
            Label descriptionlLabel = new Label();
            descriptionlLabel.Text = "Description du jeu :\n\n\"La Bataille des Programmes\" est un jeu de stratégie où \ndeux joueurs, représentant chacun un des sept programmes\n de l'Université de Technologie de Troyes (ISI, RT, A2I,\n GI, GM, MTE, MM), commandent 20 combattants pour \ncontrôler cinq zones de l'université. Les phases du\n jeu incluent le paramétrage, l'affectation, la mêlée, la trêve\n et le redéploiement des troupes.";
            descriptionlLabel.AutoSize = true;
            descriptionlLabel.Location = new Point(10, 10);
            descriptionlLabel.Font = new Font("Arial", 12);
            panel2.Controls.Add(descriptionlLabel);
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour confirmer et fermer le jeu.
        /// </summary>
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Êtes-vous sûr de vouloir fermer le jeu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        /// <summary>
        /// Gère l'événement Paint du panneau panel2.
        /// </summary>
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Code pour gérer l'événement Paint de panel2
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour afficher une image de fond.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Image backgroundImage = Properties.Resources.ac;
            panel2.Controls.Clear();
            panel2.BackgroundImage = backgroundImage;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour sélectionner une partie sauvegardée.
        /// </summary>
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.BackgroundImage = null;

            Label titre = new Label();
            titre.Text = "Sélectionner une partie sauvegardée";
            titre.AutoSize = true;
            titre.Location = new Point(10, 10);
            titre.Font = new Font("Arial", 12);
            panel2.Controls.Add(titre);

            Button b1 = new Button();
            b1.Text = "(Patrice)  ISI vs RT  (brayan)\n\n 18/05/2024";
            b1.Location = new Point(10, 40);
            b1.Size = new Size(200, 50);
            b1.Click += b1_Click;
            panel2.Controls.Add(b1);

            Button b2 = new Button();
            b2.Text = "(Vanelle)  ISI vs SN  (Giovanni)\n\n 10/05/2024";
            b2.Location = new Point(10, 100);
            b2.Size = new Size(200, 50);
            b2.Click += b2_Click;
            panel2.Controls.Add(b2);
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour charger la première partie sauvegardée.
        /// </summary>
        private static void b1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chargement de la partie sauvegardée..");
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour charger la deuxième partie sauvegardée.
        /// </summary>
        private static void b2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chargement de la partie sauvegardée..");
        }

        /// <summary>
        /// Gère l'événement Click du bouton pour démarrer un nouveau formulaire de jeu.
        /// </summary>
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form1 page2 = new Form1(this);
            page2.Show();
            this.Hide();
        }
    }
}
