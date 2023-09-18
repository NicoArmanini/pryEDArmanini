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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble FilaPersonas = new clsListaDoble();

        private void ValidarDatos()
        {
            cmbCodigo.SelectedIndex = -1;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            txtNombre.Enabled = false;
            txtTramite.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
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

                ValidarDatos();
            }
        }

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
            ValidarDatos();
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (optAscendente.Checked)
            {
                FilaPersonas.RecorrerLista(lstLista);
                FilaPersonas.RecorrerCombo(cmbCodigo);
                FilaPersonas.RecorrerGrilla(dgvTabla);

            }
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (optDescendente.Checked)
            {
                FilaPersonas.RecorrerListaDes(lstLista);
                FilaPersonas.RecorrerComboDes(cmbCodigo);
                FilaPersonas.RecorrerGrillaDes(dgvTabla);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                txtNombre.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                txtTramite.Enabled = true;
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
        }
    }
}
