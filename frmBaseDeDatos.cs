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
            String varSql = "SELECT IDLIBRO,TITULO FROM LIBRO ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT Titulo, Nombre FROM libro, Pais  Where Libro.idlibro = Pais.IdPais ";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnSelecSimple_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM Libro WHERE Cantidad >= 1";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnSelecMulti_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM Libro WHERE Cantidad >= 1 AND Precio > 130";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnSelecConv_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM (SELECT * FROM Libro WHERE IDAUTOR = 5) AS X WHERE IDIDIOMA = 3";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM Libro WHERE idIdioma = 2" +
                " Union " +
                "SELECT * FROM Libro WHERE idIdioma = 7";
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnInter_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM libro " +
                "WHERE idIdioma = 2 AND " + "idLibro in " +
                "(SELECT idLibro FROM libro WHERE IdPais = 3 ) " +
                "ORDER BY 1 ASC "; ;
            objBaseDatos.Listar(dgvBD, varSql);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM LIBRO WHERE IDIDIOMA NOT IN (SELECT DISTINCT IDIDIOMA FROM LIBRO WHERE IDIDIOMA < 5)";
            objBaseDatos.Listar(dgvBD, varSql);
        }
    }
}
