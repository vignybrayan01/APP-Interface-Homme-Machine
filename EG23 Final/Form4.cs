using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EG23
{
    /// <summary>
    /// Formulaire pour gérer les actions et l'état d'un joueur avec une barre de progression et des messages aléatoires.
    /// </summary>
    public partial class Form4 : Form
    {
        private readonly string[] messages =
        {
            "Vous dominez la halle sportive",
            "Un soldat est mort à la BU",
            "Vous gagnez les points",
            "Un maitre de guerre mort au BDE",
            "Bravo continuez comme cela"
        };

        private Random random = new Random();
        private Timer progressTimer;
        private Joueur j;
        private bool isPaused = false; // Variable pour suivre l'état de pause

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Form4"/>.
        /// </summary>
        /// <param name="j">Instance du joueur à gérer.</param>
        public Form4(Joueur j)
        {
            InitializeComponent();
            this.j = j;
            textBox5.Text = j.pseudo;
            label1.Text = j.programme;
            InitializeTimer();
        }

        /// <summary>
        /// Initialise et démarre le minuteur de progression.
        /// </summary>
        private void InitializeTimer()
        {
            progressTimer = new Timer();
            progressTimer.Interval = 300; // Intervalle de 300 ms
            progressTimer.Tick += new EventHandler(OnTimerTick);
            progressTimer.Start();
            label2.Text = j.score + "/5";
        }

        /// <summary>
        /// Gestionnaire d'événements pour le tick du minuteur de progression.
        /// Met à jour la barre de progression et affiche des messages aléatoires.
        /// </summary>
        private void OnTimerTick(object sender, EventArgs e)
        {
            // Mise à jour de la barre de progression
            if (gunaCircleProgressBar1.Value < gunaCircleProgressBar1.Maximum)
            {
                gunaCircleProgressBar1.Value++;

                // Mise à jour du label avec un message aléatoire
                label3.Text = messages[random.Next(messages.Length)];
            }
            else
            {
                progressTimer.Stop();
                j.score += 1;
                j.tour += 1;

                if (j.score == 4)
                {
                    var result = MessageBox.Show("FÉLICITATION VOUS AVEZ GAGNÉ! Voulez-vous recommencer ?",
                              "Victoire",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

                    // Vérifie le résultat de la boîte de dialogue
                    if (result == DialogResult.Yes)
                    {
                        page1 page1 = new page1();
                        page1.Show();
                        this.Close();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Form5 form5 = new Form5(j);
                    form5.Show();
                    this.Close(); // Ferme le formulaire lorsque la barre de progression est pleine
                }
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour le bouton Quitter.
        /// Affiche une boîte de dialogue de confirmation avant de quitter le jeu.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Êtes-vous sûr de vouloir quitter le jeu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifie le résultat de la boîte de dialogue
            if (result == DialogResult.Yes)
            {
                page1 page1 = new page1();
                page1.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour le bouton Pause/Reprendre.
        /// Met en pause ou reprend le minuteur de progression.
        /// </summary>
        private void button60_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                // Reprend le minuteur
                progressTimer.Start();
                button60.Text = "PAUSE";
                isPaused = false;
            }
            else
            {
                // Met le minuteur en pause
                progressTimer.Stop();
                button60.Text = "CONTINUER";
                isPaused = true;
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour le bouton2. (Non utilisé)
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            // Code à implémenter pour le bouton2
        }
    }
}
