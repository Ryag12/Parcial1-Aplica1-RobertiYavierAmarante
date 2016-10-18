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

            if (!Confirmar())
            {
                MessageBox.Show("complete todos los datos");
                return;
            }

            if (ClienteBLL.Guardar(cliente))
            {
                MessageBox.Show("El cliente ha sido registrado con exito!!");
            }
        }

        private bool Confirmar()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Debes introducir un nombre");
                errorProvider2.SetError(FechaNacmaskedTextBox, "Debes introducir la fecha de nacimiento datos");
                errorProvider3.SetError(LimiteCreditomaskedTextBox, "Debes introducir el Limite de Credito");
                errorProvider4.SetError(ClienteIdtextBox, "El usuario debe al menor contener un ID ");

                retorno = false;
            }
            return retorno;
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

            

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
