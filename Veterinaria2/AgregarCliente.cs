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
    public partial class AgregarCliente : UserControl
    {
        private Directorio miDirectorio;
        public AgregarCliente(Directorio unDirectorio)
        {
            InitializeComponent();
            miDirectorio = unDirectorio;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente
            {
                Id = (int)numId.Value,
                Nombre = tbNombre.Text,
                FechaDeNacimiento = dtpFechaDeNacimiento.Value,
                Descripcion = tbDescripcion.Text,
                EsSocio = cbEsSocio.Checked
            };
            try
            {
                TryCrearCliente(nuevoCliente);
            }
            catch (YaExisteClienteConEsaIdException unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }                  
        }

        private void TryCrearCliente(Cliente nuevoCliente)
        {
            miDirectorio.AgregarCliente(nuevoCliente);
            MessageBox.Show("Cliente " + nuevoCliente.Nombre + " ha sido creado correctamente!");
        }
    }
}
