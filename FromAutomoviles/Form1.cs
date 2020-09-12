using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromAutomoviles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbAutos.Visible = true;
            if (cbModelo.SelectedItem.Equals("Raptor"))
            {
                pbAutos.ImageLocation = "C:/Users/Fernando/Desktop/PROYECTO/Imagenes/Raptor.png";
            }
            if (cbModelo.SelectedItem.Equals("Ranger"))
            {
                pbAutos.ImageLocation = "C:/Users/Fernando/Desktop/PROYECTO/Imagenes/Ranger.png";
            }
            if (cbModelo.SelectedItem.Equals("Explorer"))
            {
                pbAutos.ImageLocation = "C:/Users/Fernando/Desktop/PROYECTO/Imagenes/Explorer.png";
            }
            if (cbModelo.SelectedItem.Equals("Edge"))
            {
                pbAutos.ImageLocation = "C:/Users/Fernando/Desktop/PROYECTO/Imagenes/Edge.png";
            }
            if (cbModelo.SelectedItem.Equals("Focus"))
            {
                pbAutos.ImageLocation = "C:/Users/Fernando/Desktop/PROYECTO/Imagenes/Focus.png";
            }
            if (cbModelo.SelectedItem.Equals("Fiesta"))
            {
                pbAutos.ImageLocation = "C:/Users/Fernando/Desktop/PROYECTO/Imagenes/Fiesta.png";
            }
            if (cbModelo.SelectedItem.Equals("B-Max"))
            {
                pbAutos.ImageLocation = "C:/Users/Fernando/Desktop/PROYECTO/Imagenes/B-Max.png";
            }
        }
    }
}
