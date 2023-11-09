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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola v = new frmCola();
            v.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila v = new frmPila();
            v.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple v = new frmListaSimple();
            v.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble v = new frmListaDoble();
            v.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmListaDoble v = new frmListaDoble();
            v.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario v = new frmArbolBinario();
            v.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador v = new frmDatosDesarrollador();
            v.ShowDialog();
        }

        private void operacionesConTablasDeBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatos v = new frmBaseDeDatos();
            v.ShowDialog();
        }

        private void consultasEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBaseDatos v = new frmConsultaBaseDatos();
            v.ShowDialog();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepaso v = new frmRepaso();
            v.ShowDialog();
        }
    }
}
