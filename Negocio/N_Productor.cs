using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using Datos;

namespace Negocio
{
    public class N_Productor
    {

        public List<E_Productor> Lista(string ID_cliente)
        {
            D_Productor productor1 = new D_Productor();
            return productor1.Lista(ID_cliente);
        }
        public List<E_Productor> ListaCompleta()
        {
            D_Productor productor1 = new D_Productor();
            return productor1.ListaCompleta();
        }
        public bool Agregar(E_Productor productor1)
        {
            D_Productor productor = new D_Productor();
            return productor.Agregar(productor1);
        }

        public bool Modificar(E_Productor productor1)
        {
            D_Productor productor = new D_Productor();
            return productor.Modificar(productor1);
        }

        public bool Borrar(string productor1)
        {
            D_Productor productor = new D_Productor();
            return productor.Borrar(productor1);
        }

        #region Metodos de prueba solo para mostrar maqueta del sistema  06-11-2018


        DataTable dtListaProductor;
        void Llena_Lista()
        {
            //DataTable dt;
            dtListaProductor = new DataTable("productor");
            dtListaProductor.Columns.Add("codigo_cliente");
            dtListaProductor.Columns.Add("codigo");
            dtListaProductor.Columns.Add("descripcion");
            DataRow row;
            for (int i = 0; i < 10; i++)
            {
                for (int h = 0; h < 10; h++)
                {
                    row = dtListaProductor.NewRow();
                    row["codigo_cliente"] = i.ToString();
                    row["Codigo"] = h.ToString();
                    row["Descripcion"] = h.ToString() + " - productor" + i.ToString() + h.ToString();
                    dtListaProductor.Rows.Add(row);
                }
            }

        }
        
        public DataTable Lista2(string codigo_cliente)
        {
            Llena_Lista();
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("descripcion");
            DataRow row2;

            foreach (DataRow row in dtListaProductor.Rows)
            {
                if (codigo_cliente == row["codigo_cliente"].ToString())
                {
                    row2 = dt.NewRow();
                    row2["codigo"] = row["codigo"];
                    row2["descripcion"] = row["descripcion"];
                    dt.Rows.Add(row2);
                }
            }

            return dt;
        }
        #endregion


    }
}
