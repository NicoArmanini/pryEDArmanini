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
    public partial class frmConsultaBaseDatos : Form
    {
        public frmConsultaBaseDatos()
        {
            InitializeComponent();
        }

        clsBaseDatos objBD = new clsBaseDatos();
        private void btnListar_Click(object sender, EventArgs e)
        { 

            String varSql = "SELECT * FROM LIBRO";
            switch (cmbConsulta.SelectedIndex)
            {
                case 0: // diferencia
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Paises que no tienen libros";
                    varSql = "SELECT * FROM PAIS WHERE IDPAIS NOT IN (SELECT IDPAIS FROM LIBRO)";
                    break;
                case 1: //interseccion
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Libros con ID menores a 20 y con un precio menor a 600";
                    varSql = "SELECT * FROM LIBRO WHERE IDLIBRO < 20 " + "INTERSECT " + "SELECT * FROM LIBRO WHERE PRECIO < 600";
                    break;
                case 2: //union
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Libros de origen Sudamericano (Argentina, Colombia, Brasil)";
                    varSql = "SELECT * FROM libro WHERE IdPais = 8 " + "UNION SELECT * FROM libro WHERE IdPais = 24 " +
                             "UNION SELECT * FROM libro WHERE IdPais = 26";
                    break;
                case 3: //proyeccion simple
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Todos los libros por titulo";
                    varSql = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
                    break;
                case 4: //proyeccion multiatributo
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Todos los libros por titulo y año ordenados por año de forma ascendente";
                    varSql = "SELECT TITULO, AÑO FROM LIBRO ORDER BY AÑO ASC";
                    break;
                case 5: //juntar
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Todos los libros por idioma";
                    varSql = "SELECT * FROM Libro, Idioma " + "WHERE Libro.IdIdioma = Idioma.IdIdioma";
                    break;
                case 6: //seleccion simple
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Todos los libros";
                    varSql = "SELECT * FROM Libro";
                    break;
                case 7: //Selección Multiatributo con operador AND
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Todos los libros de Estados Unidos y en idioma Ingles";
                    varSql = "SELECT * FROM Libro WHERE IdPais = 4 AND IdIdioma = 1";
                    break;
                case 8: //Selección Multiatributo con operador OR
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Todos los libros de Alemania o en idioma Ingles";
                    varSql = "SELECT * FROM Libro WHERE IdPais = 5 OR IdIdioma = 1";
                    break;
                case 9: //Selección Multiatributo por convulsion
                    lblDescripcion.Text = cmbConsulta.Text + ": " + "Todos los libros de autores e idiomas";
                    varSql = "SELECT * FROM Libro WHERE IdAutor > 10 " + "INTERSECT SELECT * FROM Libro WHERE IdIdioma > 5"; ;
                    break;
            }
            objBD.Listar(dgvDatos, varSql);
        }
    }
}
