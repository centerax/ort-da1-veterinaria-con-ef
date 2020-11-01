using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Veterinaria2
{
    public partial class AgregarMascota : UserControl
    {
        private Directorio miDirectorio;
        public AgregarMascota(Directorio unDirectorio)
        {
            InitializeComponent();
            miDirectorio = unDirectorio;
            CargarComboBoxClientes();
        }

        private void CargarComboBoxClientes()
        {
            cbClientes.DataSource = miDirectorio.listaClientes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Mascota nuevaMascota = new Mascota
            {
                Id = (int)numId.Value,
                Nombre = tbNombre.Text,
                Raza = tbRaza.Text,
                Duenio = (Cliente)cbClientes.SelectedValue
            };
            miDirectorio.AgregarMascota(nuevaMascota);
        }
    }
}
