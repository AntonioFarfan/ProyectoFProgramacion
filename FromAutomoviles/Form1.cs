﻿using System;
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
            if(cbModelo.SelectedItem.Equals("Raptor"))
            {
                pbAutos.ImageLocation = "C:/Users/Fernando/Desktop/PROYECTO/Imagenes/Raptor.png";
            }
        }
    }
}
