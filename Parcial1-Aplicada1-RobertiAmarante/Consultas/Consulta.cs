using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;
namespace Parcial1_Aplicada1_RobertiAmarante.Consultas
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        public List<Cliente> lista = new List<Cliente>();
        private void button1_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(FiltrartextBox.Text))
            {

                lista = BLL.ClienteBLL.GetLista(Utilidades.ToInt(FiltrartextBox.Text));
            }
            else
            {
                lista = BLL.ClienteBLL.GetLista();
            }

            dataGridView1.DataSource = lista;
        }

    }
    }
}
