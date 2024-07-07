using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EG23
{
    /// <summary>
    /// Formulaire pour gérer les actions et l'état d'un joueur et permettre des opérations de drag-and-drop sur des PictureBox.
    /// </summary>
    public partial class Form2 : Form
    {
        private PictureBox sourcePictureBox;
        private Image originalImage;
        private bool dragSucceeded;
        private page3 page;
        private Joueur j;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Form2"/>.
        /// </summary>
        /// <param name="page">Instance du formulaire page3.</param>
        /// <param name="j">Instance du joueur à gérer.</param>
        public Form2(page3 page, Joueur j)
        {
            InitializeComponent();
            this.page = page;
            this.j = j;
            textBox5.Text = j.pseudo;
            textBox2.Text = j.programme;
        }

        /// <summary>
        /// Gère l'événement Paint de panel1.
        /// </summary>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Code pour gérer l'événement Paint de panel1
        }

        /// <summary>
        /// Gère l'événement Paint de panel4.
        /// </summary>
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // Code pour gérer l'événement Paint de panel4
        }

        /// <summary>
        /// Gère l'événement Load du formulaire.
        /// Initialise les propriétés de drag-and-drop pour plusieurs PictureBox.
        /// </summary>
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox15.AllowDrop = true;
            pictureBox13.AllowDrop = true;
            pictureBox17.AllowDrop = true;
            pictureBox16.AllowDrop = true;
            pictureBox23.AllowDrop = true;
            pictureBox22.AllowDrop = true;
            pictureBox21.AllowDrop = true;
            pictureBox20.AllowDrop = true;
            pictureBox19.AllowDrop = true;
            pictureBox18.AllowDrop = true;
            pictureBox29.AllowDrop = true;
            pictureBox28.AllowDrop = true;
            pictureBox27.AllowDrop = true;
            pictureBox26.AllowDrop = true;
            pictureBox25.AllowDrop = true;
            pictureBox24.AllowDrop = true;
            pictureBox35.AllowDrop = true;
            pictureBox34.AllowDrop = true;
            pictureBox33.AllowDrop = true;
            pictureBox32.AllowDrop = true;
            pictureBox31.AllowDrop = true;
            pictureBox30.AllowDrop = true;
            pictureBox41.AllowDrop = true;
            pictureBox40.AllowDrop = true;
            pictureBox39.AllowDrop = true;
            pictureBox38.AllowDrop = true;
            pictureBox37.AllowDrop = true;
            pictureBox36.AllowDrop = true;
        }

        /// <summary>
        /// Gère l'événement Click de button60.
        /// Ouvre le formulaire Form3 et ferme le formulaire actuel.
        /// </summary>
        private void button60_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(j);
            form3.Show();
            this.Close();
        }

        /// <summary>
        /// Gère l'événement Click de pictureBox42.
        /// </summary>
        private void pictureBox42_Click(object sender, EventArgs e)
        {
            // Code pour gérer l'événement Click de pictureBox42
        }

        /// <summary>
        /// Gère l'événement TextChanged de textBox1.
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Code pour gérer l'événement TextChanged de textBox1
        }

        /// <summary>
        /// Gère l'événement MouseDown des PictureBox.
        /// Initialise l'opération de drag-and-drop pour l'image de la PictureBox source.
        /// </summary>
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            sourcePictureBox = (PictureBox)sender;

            if (sourcePictureBox.Image != null)
            {
                originalImage = sourcePictureBox.Image; // Stocke l'image d'origine
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
        /// Gère l'événement DragEnter des PictureBox.
        /// Définit l'effet de drag-and-drop sur Copy si les données sont une image.
        /// </summary>
        private void pictureBox_dragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Gère l'événement DragDrop des PictureBox.
        /// Dépose l'image dans la PictureBox cible et marque l'opération comme réussie.
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
        /// Gère l'événement DragLeave des PictureBox.
        /// Restaurer l'image d'origine si l'opération de drag-and-drop échoue.
        /// </summary>
        private void pictureBox_DragLeave(object sender, EventArgs e)
        {
            // Code pour gérer l'événement DragLeave des PictureBox
        }

        /// <summary>
        /// Gère l'événement QueryContinueDrag des PictureBox.
        /// Restaurer l'image d'origine si l'opération de drag-and-drop est annulée.
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
        /// Gère l'événement Click de button1.
        /// Affiche le formulaire page3 et cache le formulaire actuel.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            page.Show();
            this.Hide();
        }
    }
}
