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
   public class N_Cliente
    {

        public List<E_Cliente> Lista()
        { 
            D_Cliente cliente1 = new D_Cliente();
            return  cliente1.Lista();
        }

        public bool Agregar(E_Cliente cliente)
        {
            D_Cliente cliente1 = new D_Cliente();
            return cliente1.Agregar(cliente);
        }

        public bool Modificar(E_Cliente cliente)
        {
            D_Cliente cliente1 = new D_Cliente();
            return cliente1.Modificar(cliente);
        }

        public bool Borrar(string ID)
        {
            D_Cliente cliente1 = new D_Cliente();
            return cliente1.Borrar(ID);
        }


        #region  metodo de prueba solo para mostrar maqueta del sistema  06-11-2018
        public DataTable Lista2()
        {
            DataTable dt;
            dt = new DataTable("cliente");
            dt.Columns.Add("codigo");
            dt.Columns.Add("descripcion");
            DataRow row;

            for (int i = 0; i < 10; i++)
            {
                row = dt.NewRow();
                row["Codigo"] = i.ToString();
                row["Descripcion"] = i.ToString() + " - Cliente" + i.ToString();

                dt.Rows.Add(row);
                
            }


            return dt;
        }
        #endregion

    }
}
