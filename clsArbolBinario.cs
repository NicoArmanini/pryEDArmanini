using System;
using System.Collections.Generic;
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
    }
}
