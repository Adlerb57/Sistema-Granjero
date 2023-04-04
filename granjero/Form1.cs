using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace granjero
{
    public partial class ejercicio : Form
    {
        public ejercicio()
        {
            InitializeComponent();
            //imagen
            /*
            Bitmap img = new Bitmap(Application.StartupPath + @"\imagen\fondo1.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            */
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lsOrigen1_Click(object sender, EventArgs e)
        {

        }

        public void perdisteOrigen()
        {
            if((lsOrigen.Items.Count == 3 && lsOrigen.Items[1]=="Conejo" && lsOrigen.Items[0]== "Cesta de heno de alfalfa" &&
                lsOrigen.Items[2]== "Aguila Real"))
            {
                MessageBox.Show("Error el Granjero va 2do");
            }
            if ((lsOrigen.Items.Count == 2 && lsOrigen.Items[1] == "Conejo" && lsOrigen.Items[0] == "Aguila Real") ||
               (lsOrigen.Items.Count == 2 && lsOrigen.Items[0] == "Conejo" && lsOrigen.Items[1] == "Aguila Real"))
            {
                MessageBox.Show("Error La Aguila se Comera al Conejo");

            }

            if (lsOrigen.Items.Count==3 && lsOrigen.Items[0]=="Conejo" && 
                lsOrigen.Items[1]== "Cesta de heno de alfalfa" && lsOrigen.Items[2]=="Aguila Real")
            {
                MessageBox.Show("Error1");
            }
           
            if ((lsOrigen.Items.Count == 2 && lsOrigen.Items[1] == "Conejo" && lsOrigen.Items[0] == "Cesta de heno de alfalfa") ||
                (lsOrigen.Items.Count == 2 && lsOrigen.Items[0] == "Conejo" && lsOrigen.Items[1] == "Cesta de heno de alfalfa"))
            {
                MessageBox.Show("Error el Conejo se comera la Alfafa");

            }
          
          

        }
        public void perdisteBote()
        {
            if ((lssBote.Items.Count == 2 && lssBote.Items[0] == "Conejo" && lssBote.Items[1] == "Cesta de heno de alfalfa") ||
                (lssBote.Items.Count == 2 && lssBote.Items[1] == "Conejo" && lssBote.Items[0] == "Cesta de heno de alfalfa")||
                (lssBote.Items.Count == 2 && lssBote.Items[0] == "Conejo" && lssBote.Items[1] == "Aguila Real") ||
                 (lssBote.Items.Count == 2 && lssBote.Items[1] == "Conejo" && lssBote.Items[0] == "Aguila Real") ||
                  (lssBote.Items.Count == 2 && lssBote.Items[0] == "Aguila Real" && lssBote.Items[1] == "Cesta de heno de alfalfa") ||
                (lssBote.Items.Count == 2 && lssBote.Items[1] == "Aguila Real" && lssBote.Items[0] == "Cesta de heno de alfalfa"))   

              
            {

                MessageBox.Show("----------Error no puede conducir el bote sin el Granjero--------- ");
            }



   
     

            if (lssBote.Items.Count == 3 || lssBote.Items.Count == 4)
            {

                MessageBox.Show("Error Solo Hay espacio para 2");
            }
        }
        public void perdistellegada()
        {
            if ((lsLLegada.Items.Count == 2 && lsLLegada.Items[1] == "Conejo" && lsLLegada.Items[0] == "Cesta de heno de alfalfa") ||
                (lsLLegada.Items.Count == 2 && lsLLegada.Items[0] == "Conejo" && lsLLegada.Items[0] == "Cesta de heno de alfalfa"))
            {
                MessageBox.Show("Error5");
            }
            if ((lsLLegada.Items.Count == 2 && lsLLegada.Items[1] == "Conejo" && lsLLegada.Items[0] == "Aguila Real") ||
                (lsLLegada.Items.Count == 2 && lsLLegada.Items[0] == "Conejo" && lsLLegada.Items[0] == "Aguila Real"))
            {
                MessageBox.Show("Error6");
            }


        }
        private void btnOrigen_Click(object sender, EventArgs e)
        {
            try
            {
                lssBote.Items.Add(lsOrigen.SelectedItem.ToString());
                lsOrigen.Items.Remove(lsOrigen.SelectedItem.ToString());
                perdisteOrigen();
                perdisteBote();
                perdistellegada();


            }

            catch
            { }
        }

        private void btnTrasladar_Click(object sender, EventArgs e)
        {

            try
            {
                if(lssBote.Items[0].ToString()=="Granjero"||lssBote.Items[1].ToString()=="Granjero")
                {
                    for(int i = 0; i < lssBote.Items.Count; i++)
                    {
                        lsLLegada.Items.Add(lssBote.Items[i].ToString());

                    }
                    lssBote.Items.Clear();
                }
                else
                {
                    MessageBox.Show("No hay nadie que maneje el Bote");
                }
                if (lsLLegada.Items.Count == 4 )
                {
                    MessageBox.Show("Felecitaciones ah Ganado");

                }

                perdisteBote();
            }
            catch
            {

            }


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                lsOrigen.Items.Add(lssBote.SelectedItem.ToString());
                lssBote.Items.Remove(lssBote.SelectedItem.ToString());
                perdisteOrigen();
            }
            catch
            {

            }

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            try
            {
                lssBote.Items.Add(lsLLegada.SelectedItem.ToString());
                lsLLegada.Items.Remove(lsLLegada.SelectedItem.ToString());
                perdistellegada();
                perdisteBote();
               
            }

            
            catch
            {

            }
        }

        private void ejercicio_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            tHora.Text = DateTime.Now.ToString("hh:mm:ss");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tHora_Click(object sender, EventArgs e)
        {

        }

        private void lsOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

