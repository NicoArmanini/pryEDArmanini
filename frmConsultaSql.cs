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
                    lblDescripcion.Text = cmbConsulta.Text + ": " +
                        "Paises que no tienen libros ";
                    varSql = " select * from paises where " + 
                        "idpais not in " + 
                        "(select idpais from libro )";
                    break;
                case 1:
                   
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
            objBD.Listar(dgvDatos, varSql);
        }
    }
}
