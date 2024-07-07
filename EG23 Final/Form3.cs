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
    /// Formulaire pour gérer les actions et l'état d'un joueur avec des animations et des transitions entre les formulaires.
    /// </summary>
    public partial class Form3 : Form
    {
        private Joueur J;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Form3"/>.
        /// </summary>
        /// <param name="J">Instance du joueur à gérer.</param>
        public Form3(Joueur J)
        {
            InitializeComponent();
            this.J = J;
        }

        /// <summary>
        /// Gère l'événement Paint de panel1.
        /// </summary>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Code pour gérer l'événement Paint de panel1
        }

        /// <summary>
        /// Gère l'événement Tick de timer1.
        /// Augmente la largeur de panel3 et met à jour le pourcentage dans le label.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 5;

            // Calcul du pourcentage en fonction de la largeur du panel
            int b = (int)((double)panel3.Width / 305 * 100);

            // Affichage du pourcentage dans le label
            label2.Text = b.ToString() + "%";

            // Vérification si la largeur du panel dépasse 305
            if (panel3.Width > 305)
            {
                timer1.Stop();

                // Affichage de la nouvelle instance de Form4 et fermeture du formulaire actuel
                Form4 form4 = new Form4(J);
                form4.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Gère l'événement Tick de timer2.
        /// Déplace pictureBox1 vers le haut jusqu'à une certaine position, puis démarre timer3.
        /// </summary>
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 2;
            if (pictureBox1.Top <= 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        /// <summary>
        /// Gère l'événement Tick de timer3.
        /// Déplace pictureBox1 vers le bas jusqu'à une certaine position, puis redémarre timer2.
        /// </summary>
        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 2;
            if (pictureBox1.Top >= 110)
            {
                timer2.Start();
                timer3.Stop();
            }
        }
    }
}
