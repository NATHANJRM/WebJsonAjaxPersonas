using DataPersonas;
using EntityPersonas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussPersonas
{
    public class BPersonas
    {
        Dpersonas data = new Dpersonas();

        public List<EPersonas> Obtener()
        {
            List<EPersonas> p = new List<EPersonas>();
            DataTable dt = data.Obtener();

            foreach (DataRow dr in dt.Rows)
            {
                EPersonas  per = new EPersonas();

                per.id = Convert.ToInt32(dr["id"]);
                per.Nombre = Convert.ToString(dr["Nombre"]);
                per.Edad = Convert.ToInt32(dr["Edad"]);
                per.Fechaalta = Convert.ToDateTime(dr["Fechaalta"]);
                per.Paterno = Convert.ToString(dr["Paterno"]);
                per.Materno = Convert.ToString(dr["Materno"]);

                p.Add(per);
            }
            return p;
        }

        public EPersonas Obtenerid(int id)
        {
            EPersonas per = new EPersonas();
            DataRow dr = data.Obtenerid(id);

            per.id = Convert.ToInt32(dr["id"]);
            per.Nombre = Convert.ToString(dr["Nombre"]);
            per.Edad = Convert.ToInt32(dr["Edad"]);
            per.Fechaalta = Convert.ToDateTime(dr["Fechaalta"]);
            per.Paterno = Convert.ToString(dr["Paterno"]);
            per.Materno = Convert.ToString(dr["Materno"]);

            return per;
        }

        public void Agregar(EPersonas per)
        {
            data.agregar(per.Nombre, per.Paterno, per.Materno, per.Edad, per.Fechaalta);            
        }

        public void Editar (EPersonas per)
        {
            data.Editar(per.Nombre, per.Paterno, per.Materno, per.Edad, per.Fechaalta, per.id);
        }

        public void Eliminar(int id)
        {
            data.Eliminar(id);
        }

        public List<EPersonas> Buscar(string valor)
        {
            List<EPersonas> p = new List<EPersonas>();
            DataTable dt = data.Buscar(valor);

            foreach (DataRow dr in dt.Rows)
            {
                EPersonas per = new EPersonas();

                per.id = Convert.ToInt32(dr["id"]);
                per.Nombre = Convert.ToString(dr["Nombre"]);
                per.Edad = Convert.ToInt32(dr["Edad"]);
                per.Fechaalta = Convert.ToDateTime(dr["Fechaalta"]);
                per.Paterno = Convert.ToString(dr["Paterno"]);
                per.Materno = Convert.ToString(dr["Materno"]);

                p.Add(per);
            }
            return p;
        }
    }
}
