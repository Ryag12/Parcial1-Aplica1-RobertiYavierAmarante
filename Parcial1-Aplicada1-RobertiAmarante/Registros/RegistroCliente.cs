using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using DAL;
using BLL;

namespace Parcial1_Aplicada1_RobertiAmarante.Registros
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (ClienteBLL.Guardar(cliente))
            {
                MessageBox.Show("El cliente ha sido registrado con exito!!");
            }
        }

        private Cliente LLenarFormulario()
        {
            Cliente Cliente = new Cliente();
            Cliente.Nombre = NombretextBox.Text;
            Cliente.FechaNacimiento = FechaNacmaskedTextBox.Text;
            Cliente.LimiteCredito = LimiteCreditomaskedTextBox.Text;

            return Cliente;

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if(ClienteBLL.Eliminar())

        }
    }
}
