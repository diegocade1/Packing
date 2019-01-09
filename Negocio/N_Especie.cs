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
   public class N_Especie
    {

        public List<E_Especie> Lista()
        {
            D_Especie especie1 = new D_Especie();
            return especie1.Lista();
        }

        #region  metodo de prueba solo para mostrar maqueta del sistema  06-11-2018
        public DataTable Lista2()
        {
            DataTable dt;
            dt = new DataTable("especie");
            dt.Columns.Add("codigo");
            dt.Columns.Add("descripcion");
            DataRow row;

            for (int i = 0; i < 5; i++)
            {
                row = dt.NewRow();
                row["Codigo"] = i.ToString();
                row["Descripcion"] = i.ToString() + " - Arandano " + i.ToString();

                dt.Rows.Add(row);

            }
            for (int i = 0; i < 5; i++)
            {
                row = dt.NewRow();
                row["Codigo"] = i.ToString();
                row["Descripcion"] = i.ToString() + " - Cereza " + i.ToString();

                dt.Rows.Add(row);

            }


            return dt;
        }
        #endregion

        public bool Agregar(E_Especie especie1)
        {
            D_Especie especie = new D_Especie();
            return especie.Agregar(especie1);
        }

        public bool Modificar(E_Especie especie1)
        {
            D_Especie especie = new D_Especie();
            return especie.Modificar(especie1);
        }

        public bool Borrar(string especie1)
        {
            D_Especie especie = new D_Especie();
            return especie.Borrar(especie1);
        }

        public void Actualizar_Fecha_uso(string ID_Especie)
        {
            D_Especie especie1 = new D_Especie();
            especie1.Actualizar_Fecha_uso(ID_Especie);
        }

    }
}
