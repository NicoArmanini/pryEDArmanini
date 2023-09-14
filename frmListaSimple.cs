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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple FilaPersonas = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            FilaPersonas.Agregar(objNodo);
            FilaPersonas.RecorrerCombo(cmbCodigo);
            FilaPersonas.RecorrerGrilla(dgvTabla);
            FilaPersonas.RecorrerLista(lstLista);
            FilaPersonas.RecorrerArchivo();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaPersonas.Primero != null)
            {
                Int32 Codigo = Convert.ToInt32(cmbCodigo.Text);

                FilaPersonas.Eliminar(Codigo);
                FilaPersonas.RecorrerCombo(cmbCodigo);
                FilaPersonas.RecorrerGrilla(dgvTabla);
                FilaPersonas.RecorrerLista(lstLista);
                FilaPersonas.RecorrerArchivo();

                ValidarDatos();
            }

            
            
            
        }

        private void ValidarDatos()
        {
            cmbCodigo.SelectedIndex = -1;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mrcEliminado_Enter(object sender, EventArgs e)
        {

        }
    }
}
