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
            String varSql = "SELECT TITULO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBD, varSql); 
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM Libro";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSql = "Select * from libro, Idioma " +
                "where Libro.IdIdioma = Idioma.IdIdioma ";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnSelecSimple_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM Libro WHERE idlibro > 20";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnSelecMulti_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM Libro WHERE idIdioma = 3 And idAutor = 18" ;
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnSelecConv_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM " +
                "(SELECT * FROM Libro AS T1 WHERE T1.IdIdioma > 5 ) " +
                "AS T2 WHERE T2.IdAutor > 10";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM libro WHERE IdAutor = 2 " +
              "UNION SELECT * FROM libro WHERE IdAutor = 5 " +
              "UNION SELECT * FROM libro WHERE IdAutor = 3";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            String varSql = "Select * from libro " + "where idIdioma = 2 and " + "idLibro in " +
                " (Select idLibro from libro where IdPais = 3) " + "order by 1 asc ";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM libro WHERE IdIdioma " +
                "NOT IN " +
                "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5 ) ";
            objBaseDatos.Listar(dgvBD, varSql);
        }
    }
}
