using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2
{
    public partial class PantallaPrincipal : Form
    {
        public Directorio DirectorioPrincipal { get; set; }
        public PantallaPrincipal()
        {
            InitializeComponent();
            DirectorioPrincipal = new Directorio();
            
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarCliente = new AgregarCliente(DirectorioPrincipal);
            panelPrincipal.Controls.Add(agregarCliente);
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarMascota = new AgregarMascota(DirectorioPrincipal);
            panelPrincipal.Controls.Add(agregarMascota);
        }
    }
}
