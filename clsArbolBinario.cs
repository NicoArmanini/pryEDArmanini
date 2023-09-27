using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace pryEDArmanini
{
    internal class clsArbolBinario
    {
        private clsNodo Inicio;

        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }
        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                //afuera del while
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }
        //comboBOX
        public void RecorrerCombo(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }
        private void InOrdenAsc(ComboBox cmb, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(cmb, R.Izquierdo);
            }
            cmb.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(cmb, R.Derecho);
            }
        }
        //dataGridView
        public void RecorrerInOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        private void InOrdenAsc(DataGridView dgvTabla, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgvTabla, R.Izquierdo);
            dgvTabla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(dgvTabla, R.Derecho);
        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenAsc(Grilla, Raiz);
        }
        private void PreOrdenAsc(DataGridView dgvTabla, clsNodo R)
        {
            dgvTabla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrdenAsc(dgvTabla, R.Izquierdo);
            if (R.Derecho != null) PreOrdenAsc(dgvTabla, R.Derecho);
        }

        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrdenAsc(Grilla, Raiz);
        }

        private void PostOrdenAsc(DataGridView dgvTabla, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrdenAsc(dgvTabla, R.Izquierdo);
            if (R.Derecho != null) PostOrdenAsc(dgvTabla, R.Derecho);
            dgvTabla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        private clsNodo[] Vector = new clsNodo[100];
        private int i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i­-1);
        }
        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i-1);
        }
        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m -1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        //que esto se pase a un treeview
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }

        public void ExportarIn(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolInOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados en el archivo de texto correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }

        public void ExportarPre(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolPreOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados en el archivo de texto correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }

        public void ExportarPost(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolPostOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados en el archivo de texto correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }
    }
}
