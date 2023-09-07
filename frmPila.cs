using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDArmanini
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila FilaPersonas = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            FilaPersonas.Agregar(objNodo);
            FilaPersonas.RecorrerGrilla(dgvTabla);
            FilaPersonas.RecorrerLista(lstLista);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaPersonas.Primero != null)
            {
                lblCod1.Text = FilaPersonas.Primero.Codigo.ToString();
                lblNom1.Text = FilaPersonas.Primero.Nombre;
                lblTram1.Text = FilaPersonas.Primero.Tramite;

                FilaPersonas.Eliminar();
                FilaPersonas.RecorrerGrilla(dgvTabla);
                FilaPersonas.RecorrerLista(lstLista);
            }
            else
            {
                lblCod1.Text = "";
                lblNom1.Text = "";
                lblTram1.Text = "";
            }
        }
    }
}
