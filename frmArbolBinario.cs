using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryEDArmanini
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario objArbol = new clsArbolBinario();

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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            objArbol.Agregar(Persona);
            objArbol.RecorrerCombo(cmbCodigo);
            objArbol.RecorrerInOrden(dgvTabla);
            objArbol.Recorrer(trvCuadro);

            ValidarDatos();
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

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrden.Checked)
            {
                objArbol.RecorrerInOrden(dgvTabla);
            }
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPreOrden.Checked)
            {
                objArbol.RecorrerPreOrden(dgvTabla);
            }
        }
        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPostOrden.Checked)
            {
                objArbol.RecorrerPostOrden(dgvTabla);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if(optInOrden.Checked)
            {
                objArbol.ExportarInOrden(dgvTabla);
            }
            else
            {
                if (optPreOrden.Checked)
                {
                    objArbol.ExportarPreOrden(dgvTabla);
                }
                else
                {
                    if (optPostOrden.Checked)
                    {
                        objArbol.ExportarPostOrden(dgvTabla);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una opcion de ordenamiento", "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            objArbol.Equilibrar();
            objArbol.RecorrerInOrden(dgvTabla);
            objArbol.Recorrer(trvCuadro);
            objArbol.RecorrerCombo(cmbCodigo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objArbol.Eliminar(Convert.ToInt32(cmbCodigo.Text));
            objArbol.RecorrerInOrden(dgvTabla);
            objArbol.Recorrer(trvCuadro);
            objArbol.RecorrerCombo(cmbCodigo);

           ValidarDatos();
        }
    }
}
