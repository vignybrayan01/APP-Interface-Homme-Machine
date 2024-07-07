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
    /// Formulaire pour gérer les actions et l'état d'un joueur avec la fonctionnalité de glisser-déposer.
    /// </summary>
    public partial class Form5 : Form
    {
        private PictureBox sourcePictureBox;
        private Image originalImage;
        private bool dragSucceeded;
        private page3 page;
        private Joueur j;
        private int var;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Form5"/>.
        /// </summary>
        /// <param name="j">Instance du joueur à gérer.</param>
        public Form5(Joueur j)
        {
            InitializeComponent();
            this.j = j;
            textBox5.Text = j.pseudo;
            textBox2.Text = j.programme;
            textBox6.Text = "Vous avez gagné. votre score : " + j.score + "/5";

            var = 0;
        }


        /// <summary>
        /// Gestionnaire d'événements pour la peinture du panel12.
        /// </summary>
        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Gestionnaire d'événements pour le chargement du formulaire.
        /// Active la fonctionnalité de glisser-déposer pour les PictureBox spécifiés.
        /// </summary>
        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox15.AllowDrop = true;
            pictureBox13.AllowDrop = true;
            pictureBox20.AllowDrop = true;
            pictureBox27.AllowDrop = true;
            pictureBox35.AllowDrop = true;
            pictureBox32.AllowDrop = true;
        }

        /// <summary>
        /// Gestionnaire d'événements pour le début du glisser-déposer des images.
        /// </summary>
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            sourcePictureBox = (PictureBox)sender;

            if (sourcePictureBox.Image != null)
            {
                originalImage = sourcePictureBox.Image; // Stockez l'image d'origine
                Bitmap bitmap = new Bitmap(sourcePictureBox.Image);
                sourcePictureBox.Image = null; // Efface l'image du PictureBox source
                dragSucceeded = false;
                DragDropEffects result = sourcePictureBox.DoDragDrop(bitmap, DragDropEffects.Copy);

                if (result != DragDropEffects.Copy)
                {
                    // Si le drag-and-drop échoue, restaurer l'image
                    sourcePictureBox.Image = originalImage;
                }
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour le début du glisser-déposer des images avec vérification de l'état.
        /// </summary>
        private void pictureBox_MouseDown1(object sender, MouseEventArgs e)
        {
            if (var == 0)
            {
                sourcePictureBox = (PictureBox)sender;

                if (sourcePictureBox.Image != null)
                {
                    originalImage = sourcePictureBox.Image; // Stockez l'image d'origine
                    Bitmap bitmap = new Bitmap(sourcePictureBox.Image);
                    sourcePictureBox.Image = null; // Efface l'image du PictureBox source
                    dragSucceeded = false;
                    DragDropEffects result = sourcePictureBox.DoDragDrop(bitmap, DragDropEffects.Copy);

                    if (result != DragDropEffects.Copy)
                    {
                        // Si le drag-and-drop échoue, restaurer l'image
                        sourcePictureBox.Image = originalImage;
                    }
                }
                var = 1;
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour l'entrée de l'objet de glisser-déposer dans la zone cible.
        /// </summary>
        private void pictureBox_dragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Gestionnaire d'événements pour le dépôt de l'objet de glisser-déposer dans la zone cible.
        /// </summary>
        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                Bitmap getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                PictureBox targetPictureBox = (PictureBox)sender;
                targetPictureBox.Image = getPicture;

                dragSucceeded = true;
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour quitter la zone de dépôt lors du glisser-déposer.
        /// </summary>
        private void pictureBox_DragLeave(object sender, EventArgs e)
        {
            // Code à implémenter si nécessaire pour gérer l'événement de sortie de la zone de dépôt
        }

        /// <summary>
        /// Gestionnaire d'événements pour continuer ou annuler le glisser-déposer.
        /// </summary>
        private void pictureBox_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (e.Action == DragAction.Cancel || e.Action == DragAction.Drop)
            {
                if (e.Action == DragAction.Cancel && sourcePictureBox != null && sourcePictureBox.Image == null)
                {
                    // Restaurer l'image si le drag-and-drop est annulé
                    sourcePictureBox.Image = originalImage;
                    originalImage = null;
                }
                // Déconnexion de l'événement après avoir agi

                ((Control)sender).QueryContinueDrag -= new QueryContinueDragEventHandler(pictureBox_QueryContinueDrag);
            }
        }

        /// <summary>
        /// Gestionnaire d'événements pour le bouton Recommencer.
        /// Affiche le formulaire Form4 et cache le formulaire actuel.
        /// </summary>
        private void button60_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(j);
            form4.Show();
            this.Hide();
        }

        private void Form5_Activated(object sender, EventArgs e)
        {
            if (j.tour == 2)
            {
                j.score -= 1;
                pictureBox32.Image = null;
                pictureBox33.Image = null;
                pictureBox34.Image = null;
                pictureBox35.Image = null;
                pictureBox35.AllowDrop = false;
                pictureBox32.AllowDrop = false;
                textBox6.Text = "Vous avez perdu la zone administrative. votre score : " + j.score + "/5";
                textBox6.ForeColor = Color.Red;
                panel8.BackColor = Color.Red;
            }
            else if (j.tour == 3)
            {
                pictureBox32.Image = null;
                pictureBox33.Image = null;
                pictureBox34.Image = null;
                pictureBox35.Image = null;
                pictureBox35.AllowDrop = false;
                pictureBox32.AllowDrop = false;
                panel8.BackColor = Color.Red;

                pictureBox20.Image = null;
                pictureBox21.Image = null;
                pictureBox23.Image = null;
                pictureBox20.AllowDrop = false;
                panel5.BackColor = Color.Green;

            }
            else if (j.tour == 4)
            {
                pictureBox32.Image = null;
                pictureBox33.Image = null;
                pictureBox34.Image = null;
                pictureBox35.Image = null;
                pictureBox35.AllowDrop = false;
                pictureBox32.AllowDrop = false;
                panel8.BackColor = Color.Red;

                pictureBox20.Image = null;
                pictureBox21.Image = null;
                pictureBox23.Image = null;
                pictureBox20.AllowDrop = false;
                panel5.BackColor = Color.Green;

                pictureBox15.Image = null;
                pictureBox13.Image = null;
                pictureBox4.Image = null;
                pictureBox15.AllowDrop = false;
                pictureBox13.AllowDrop = false;
                panel4.BackColor = Color.Green;
            }
        }
    }
}