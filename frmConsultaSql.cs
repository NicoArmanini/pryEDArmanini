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
    public partial class frmConsultaSql : Form
    {
        public frmConsultaSql()
        {
            InitializeComponent();
        }

        clsBaseDatos objBD = new clsBaseDatos();
        private void btnListar_Click(object sender, EventArgs e)
        {
            //frmREPASO
            //clsBaseDatos objBaseDatos = new clsBaseDatos();
            //objBaseDatos.Listar(dgvDatos, txtSql.Text);

            String varSql = "SELECT * FROM LIBRO";
            switch (cmbConsulta.SelectedIndex)
            {
                case 0:
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Paises que no tienen libros";
                    varSql = "SELECT * FROM PAIS WHERE IDPAIS NOT IN (SELECT IDPAIS FROM LIBRO)";
                    break;
                case 1:
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Libros con ID menores a 20 y con un precio menor a 600";
                    varSql = "SELECT * FROM LIBRO WHERE IDLIBRO < 20 " +
                        "INTERSECT " +
                        "SELECT * FROM LIBRO WHERE PRECIO < 600";
                    break;
                case 2:
                    varSql = "SELECT * FROM LIBRO WHERE IDIDIOMA = 4 " +
                        "UNION " +
                        "SELECT * FROM LIBRO WHERE PRECIO < 600";
                    break;
                case 3:
                    varSql = "SELECT Titulo, Nombre FROM libro, Pais  Where Libro.idlibro = Pais.IdPais ";
                    break;
                case 4:
                    varSql = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
                    break;
                case 5:
                    varSql = "SELECT IDLIBRO,TITULO FROM LIBRO ORDER BY 1 DESC";
                    break;
            }
            objBD.Listar(dgvDatos, varSql);
        }
    }
}
