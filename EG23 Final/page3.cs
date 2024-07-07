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

    public partial class page3 : Form
    {
        private Joueur joueur { get; set; }
        private Form1 page;
        private bool isCheck= false ;
        public page3(Form1 form1, Joueur joueur)
        {
            InitializeComponent();
            this.joueur = joueur;
            textBox4.Text = joueur.pseudo;
            textBox2.Text = joueur.programme;
            this.page = form1;

            int z = 30;
            button33.Text = z.ToString();
            button27.Text = z.ToString();
            button21.Text = z.ToString();
            button3.Text = z.ToString();
            button5.Text = z.ToString();
            button15.Text = z.ToString();
            button51.Text = z.ToString();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            int q = int.Parse(button59.Text);
            if (q <= 0)
            {

            }
            else
            {

                if (checkBox1.Checked)
                {


                    int a = int.Parse(button35.Text);

                    if (a>=0 && a <10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 3;
                        button59.Text = p.ToString();

                        a += 1;
                        button35.Text = a.ToString();

                        a = int.Parse(button29.Text);
                        a += 1;
                        button29.Text = a.ToString();

                        a = int.Parse(button23.Text);
                        a += 1;
                        button23.Text = a.ToString();
                    }
                }

                if (checkBox2.Checked)
                {
                    int a = int.Parse(button6.Text);


                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 3;
                        button59.Text = p.ToString();

                         
                        a += 1;
                        button6.Text = a.ToString();

                        a = int.Parse(button7.Text);
                        a += 1;
                        button7.Text = a.ToString();

                        a = int.Parse(button17.Text);
                        a += 1;
                        button17.Text = a.ToString();
                    }
                }

                if (checkBox3.Checked)
                {
                    int a = int.Parse(button53.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 1;
                        button59.Text = p.ToString();

                         
                        a += 1;
                        button53.Text = a.ToString();

                    }
                }
            }

        }

        private void button40_Click(object sender, EventArgs e)
        {

            int q = int.Parse(button59.Text);

            if (q >= 400)
            {

            }
            else
            {
                if (checkBox1.Checked)
                {
                    int a = int.Parse(button35.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 3;
                        button59.Text = p.ToString();

                        a -= 1;
                        button35.Text = a.ToString();

                        a = int.Parse(button29.Text);
                        a -= 1;
                        button29.Text = a.ToString();

                        a = int.Parse(button23.Text);
                        a -= 1;
                        button23.Text = a.ToString();
                    }
                }

                if (checkBox2.Checked)
                {
                    int a = int.Parse(button6.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 3;
                        button59.Text = p.ToString();

                        a -= 1;
                        button6.Text = a.ToString();

                        a = int.Parse(button7.Text);
                        a -= 1;
                        button7.Text = a.ToString();

                        a = int.Parse(button17.Text);
                        a -= 1;
                        button17.Text = a.ToString();
                    }
                }

                if (checkBox3.Checked)
                {
                    int a = int.Parse(button53.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 1;
                        button59.Text = p.ToString();


                        a -= 1;
                        button53.Text = a.ToString();

                    }
                }
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {


            int q = int.Parse(button59.Text);
            if (q <= 0)
            {

            }
            else
            {
                if (checkBox1.Checked)
                {
                    int a = int.Parse(button36.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 3;
                        button59.Text = p.ToString();

                        a += 1;
                        button36.Text = a.ToString();

                        a = int.Parse(button30.Text);
                        a += 1;
                        button30.Text = a.ToString();

                        a = int.Parse(button24.Text);
                        a += 1;
                        button24.Text = a.ToString();
                    }
                }

                if (checkBox2.Checked)
                {
                    int a = int.Parse(button12.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 3;
                        button59.Text = p.ToString();

                        a += 1;
                        button12.Text = a.ToString();

                        a = int.Parse(button8.Text);
                        a += 1;
                        button8.Text = a.ToString();

                        a = int.Parse(button18.Text);
                        a += 1;
                        button18.Text = a.ToString();
                    }
                }

                if (checkBox3.Checked)
                {
                    int a = int.Parse(button54.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 1;
                        button59.Text = p.ToString();


                        a += 1;
                        button54.Text = a.ToString();
                    }

                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            int q = int.Parse(button59.Text);

            if (q >= 400)
            {

            }
            else
            {
                if (checkBox1.Checked)
                {
                    int a = int.Parse(button36.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 3;
                        button59.Text = p.ToString();

                        a -= 1;
                        button36.Text = a.ToString();

                        a = int.Parse(button30.Text);
                        a -= 1;
                        button30.Text = a.ToString();

                        a = int.Parse(button24.Text);
                        a -= 1;
                        button24.Text = a.ToString();
                    }
                }

                if (checkBox2.Checked)
                {
                    int a = int.Parse(button12.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 3;
                        button59.Text = p.ToString();

                        a -= 1;
                        button12.Text = a.ToString();

                        a = int.Parse(button8.Text);
                        a -= 1;
                        button8.Text = a.ToString();

                        a = int.Parse(button18.Text);
                        a -= 1;
                        button18.Text = a.ToString();
                    }
                }

                if (checkBox3.Checked)
                {

                    int a = int.Parse(button54.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 1;
                        button59.Text = p.ToString();


                        a -= 1;
                        button54.Text = a.ToString();
                    }

                }
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            int q = int.Parse(button59.Text);
            if (q <= 0)
            {

            }
            else
            {
                if (checkBox1.Checked)
                {
                    int a = int.Parse(button34.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 3;
                        button59.Text = p.ToString();

                        a += 1;
                        button34.Text = a.ToString();

                        a = int.Parse(button28.Text);
                        a += 1;
                        button28.Text = a.ToString();

                        a = int.Parse(button22.Text);
                        a += 1;
                        button22.Text = a.ToString();
                    }
                }

                if (checkBox2.Checked)
                {
                    int a = int.Parse(button4.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 3;
                        button59.Text = p.ToString();

                        a += 1;
                        button4.Text = a.ToString();

                        a = int.Parse(button9.Text);
                        a += 1;
                        button9.Text = a.ToString();

                        a = int.Parse(button16.Text);
                        a += 1;
                        button16.Text = a.ToString();
                    }
                }

                if (checkBox3.Checked)
                {
                    int a = int.Parse(button52.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 1;
                        button59.Text = p.ToString();


                        a += 1;
                        button52.Text = a.ToString();
                    }

                }
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            int q = int.Parse(button59.Text);

            if (q >= 400)
            {

            }
            else
            {
                if (checkBox1.Checked)
                {
                    int a = int.Parse(button34.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 3;
                        button59.Text = p.ToString();

                        a -= 1;
                        button34.Text = a.ToString();

                        a = int.Parse(button28.Text);
                        a -= 1;
                        button28.Text = a.ToString();

                        a = int.Parse(button22.Text);
                        a -= 1;
                        button22.Text = a.ToString();
                    }
                }

                if (checkBox2.Checked)
                {
                    int a = int.Parse(button4.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 3;
                        button59.Text = p.ToString();

                        a -= 1;
                        button4.Text = a.ToString();

                        a = int.Parse(button9.Text);
                        a -= 1;
                        button9.Text = a.ToString();

                        a = int.Parse(button16.Text);
                        a -= 1;
                        button16.Text = a.ToString();
                    }
                }

                if (checkBox3.Checked)
                {
                    int a = int.Parse(button52.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 1;
                        button59.Text = p.ToString();

                        a -= 1;
                        button52.Text = a.ToString();
                    }

                }
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            int q = int.Parse(button59.Text);
            if (q <= 0)
            {

            }
            else
            {
                if (checkBox1.Checked)
                {
                    int a = int.Parse(button32.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 3;
                        button59.Text = p.ToString();

                        a += 1;
                        button32.Text = a.ToString();

                        a = int.Parse(button26.Text);
                        a += 1;
                        button26.Text = a.ToString();

                        a = int.Parse(button20.Text);
                        a += 1;
                        button20.Text = a.ToString();
                    }
                }

                if (checkBox2.Checked)
                {
                    int a = int.Parse(button2.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 3;
                        button59.Text = p.ToString();

                        a += 1;
                        button2.Text = a.ToString();

                        a = int.Parse(button10.Text);
                        a += 1;
                        button10.Text = a.ToString();

                        a = int.Parse(button14.Text);
                        a += 1;
                        button14.Text = a.ToString();
                    }
                }

                if (checkBox3.Checked)
                {
                    int a = int.Parse(button50.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 1;
                        button59.Text = p.ToString();

                        a += 1;
                        button50.Text = a.ToString();
                    }

                }
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            int q = int.Parse(button59.Text);

            if (q >= 400)
            {

            }
            else
            {
                if (checkBox1.Checked)
                {
                    int a = int.Parse(button32.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 3;
                        button59.Text = p.ToString();

                        a -= 1;
                        button32.Text = a.ToString();

                        a = int.Parse(button26.Text);
                        a -= 1;
                        button26.Text = a.ToString();

                        a = int.Parse(button20.Text);
                        a -= 1;
                        button20.Text = a.ToString();
                    }
                }

                if (checkBox2.Checked)
                {
                    int a = int.Parse(button2.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 3;
                        button59.Text = p.ToString();

                        a -= 1;
                        button2.Text = a.ToString();

                        a = int.Parse(button10.Text);
                        a -= 1;
                        button10.Text = a.ToString();

                        a = int.Parse(button14.Text);
                        a -= 1;
                        button14.Text = a.ToString();
                    }
                }

                if (checkBox3.Checked)
                {
                    int a = int.Parse(button50.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 1;
                        button59.Text = p.ToString();

                        a -= 1;
                        button50.Text = a.ToString();
                    }

                }
            }

        }

        private void button57_Click(object sender, EventArgs e)
        {
            int q = int.Parse(button59.Text);
            if (q <= 0)
            {

            }
            else
            {
                if (checkBox1.Checked)
                {
                    int a = int.Parse(button31.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 3;
                        button59.Text = p.ToString();

                        a += 1;
                        button31.Text = a.ToString();

                        a = int.Parse(button25.Text);
                        a += 1;
                        button25.Text = a.ToString();

                        a = int.Parse(button19.Text);
                        a += 1;
                        button19.Text = a.ToString();
                    }
                }

                if (checkBox2.Checked)
                {
                    int a = int.Parse(button1.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 3;
                        button59.Text = p.ToString();

                        a += 1;
                        button1.Text = a.ToString();

                        a = int.Parse(button11.Text);
                        a += 1;
                        button11.Text = a.ToString();

                        a = int.Parse(button13.Text);
                        a += 1;
                        button13.Text = a.ToString();
                    }
                }

                if (checkBox3.Checked)
                {
                    int a = int.Parse(button49.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p -= 1;
                        button59.Text = p.ToString();

                        a += 1;
                        button49.Text = a.ToString();
                    }

                }
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {

            int q = int.Parse(button59.Text);

            if (q >= 400)
            {

            }
            else
            {
                if (checkBox1.Checked)
                {
                    int a = int.Parse(button31.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 3;
                        button59.Text = p.ToString();

                        a -= 1;
                        button31.Text = a.ToString();

                        a = int.Parse(button25.Text);
                        a -= 1;
                        button25.Text = a.ToString();

                        a = int.Parse(button19.Text);
                        a -= 1;
                        button19.Text = a.ToString();
                    }
                }

                if (checkBox2.Checked)
                {
                    int a = int.Parse(button1.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 3;
                        button59.Text = p.ToString();

                        a -= 1;
                        button1.Text = a.ToString();

                        a = int.Parse(button11.Text);
                        a -= 1;
                        button11.Text = a.ToString();

                        a = int.Parse(button13.Text);
                        a -= 1;
                        button13.Text = a.ToString();
                    }
                }

                if (checkBox3.Checked)
                {
                    int a = int.Parse(button49.Text);
                    if (a >=0 && a < 10)
                    {
                        int p = int.Parse(button59.Text);
                        p += 1;
                        button59.Text = p.ToString();

                        a -= 1;
                        button49.Text = a.ToString();
                    }

                }
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, joueur);
            form2.Show();
            this.Hide();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            page.Show();
            this.Hide();


        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            isCheck = checkBox1.Checked;

        }
    }
}