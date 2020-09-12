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

        public List<Automoviles> datosAutomoviles;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarInformacion())
                {
                    Automoviles automovil = new Automoviles();
                    automovil.Placa = txtPlaca.Text;
                    automovil.Kilometraje = Convert.ToInt32(mtxtKilometraje.Text);
                    automovil.Dueño = txtDueño.Text;
                    datosAutomoviles.Add(automovil);
                    MessageBox.Show("Datos guardados correctamente.");
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Ingrese toda la información");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbAutos.Visible = true;
            if (cbModelo.SelectedItem.Equals("Raptor"))
            {
                pbAutos.ImageLocation = "https://github.com/AntonioFarfan/ProyectoFProgramacion/blob/master/Imagenes/Raptor.png?raw=true";
            }
            if (cbModelo.SelectedItem.Equals("Ranger"))
            {
                pbAutos.ImageLocation = "https://github.com/AntonioFarfan/ProyectoFProgramacion/blob/master/Imagenes/Ranger.png?raw=true";
            }
            if (cbModelo.SelectedItem.Equals("Explorer"))
            {
                pbAutos.ImageLocation = "https://github.com/AntonioFarfan/ProyectoFProgramacion/blob/master/Imagenes/Explorer.png?raw=true";
            }
            if (cbModelo.SelectedItem.Equals("Edge"))
            {
                pbAutos.ImageLocation = "https://github.com/AntonioFarfan/ProyectoFProgramacion/blob/master/Imagenes/Edge.png?raw=true";
            }
            if (cbModelo.SelectedItem.Equals("Focus"))
            {
                pbAutos.ImageLocation = "https://github.com/AntonioFarfan/ProyectoFProgramacion/blob/master/Imagenes/Focus.png?raw=true";
            }
            if (cbModelo.SelectedItem.Equals("Fiesta"))
            {
                pbAutos.ImageLocation = "https://github.com/AntonioFarfan/ProyectoFProgramacion/blob/master/Imagenes/Fiesta.png?raw=true";
            }
            if (cbModelo.SelectedItem.Equals("B-Max"))
            {
                pbAutos.ImageLocation = "https://github.com/AntonioFarfan/ProyectoFProgramacion/blob/master/Imagenes/B-Max.png?raw=true";
            }
        }

        public bool VerificarInformacion()
        {
            bool verifica = false;
            if (txtPlaca.Text != "" && mtxtKilometraje.Text != ""&&txtDueño.Text!="")
            {
                verifica = true;
            }
            return verifica;
        }
        public void LimpiarControles()
        {
            txtPlaca.Text = "";
            mtxtKilometraje.Text = "";
            txtDueño.Text = "";
        }

    }
}
