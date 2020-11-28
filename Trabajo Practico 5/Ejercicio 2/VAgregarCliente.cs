using Ejercicio_2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class VAgregarCliente : Form
    {
        public VAgregarCliente()
        {
            InitializeComponent();
            TipoDocumentoCb.DataSource = Enum.GetValues(typeof(TipoDocumento));
        }

        private void AgregarClienteBtn_Click(object sender, EventArgs e)
        {
            var documento = new Documento
            {
                Numero = NumeroDocumentoClienteTb.Text,
                Tipo = (TipoDocumento)TipoDocumentoCb.SelectedItem,
            };
            var cliente = new Cliente
            {
                Nombre = NombreClienteTb.Text,
                Apellido = ApellidoClienteTb.Text,
                Documento = documento
            };
            fachada.AgregarCliente(cliente);
            Dispose();
        }
    }
}
