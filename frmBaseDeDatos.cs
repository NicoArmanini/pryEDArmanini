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
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void btnSimple_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT TITULO " + "FROM LIBRO " + "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBD, varSql); 
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            String varSql = "Select * from libro " + "where IdAutor = 2 " + "order by 1 asc ";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSql = "Select * from libro, Idioma " + "where Libro.IdIdioma = Idioma.IdIdioma " + "order by 1 asc ";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnSelecSimple_Click(object sender, EventArgs e)
        {
            String varSql = "Select * from libro " + "where IdAutor = 2 " + "order by 1 asc ";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnSelecMulti_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecConv_Click(object sender, EventArgs e)
        {
            String varSql = "Select * from libro, Idioma " + "where Libro.IdIdioma = Idioma.IdIdioma " + "order by 1 asc ";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {

        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            String varSql = "Select * from libro " + "where idIdioma = 2 and " + "idLibro in " +
                " (Select idLibro from libro where IdPais = 3) " + "order by 1 asc ";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {

        }
    }
}
