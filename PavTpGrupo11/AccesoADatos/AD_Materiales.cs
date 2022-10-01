using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_Materiales
    {
        ConexionSQL cn = new ConexionSQL();
        public DataTable ConsultarMaterialesDG()
        {
            return cn.ConsultarMaterialesDG();
        }
        public int InsertarMaterial(string codMaterial, string cant, string codUnidadMedida, string codProv, string fechaIngreso, string precio)
        {
            return cn.InsertarMaterial(codMaterial, cant, codUnidadMedida, codProv, fechaIngreso, precio);
        }
        public int ModificarMaterial(string codMaterial, string cant, string codUnidadMedida, string codProv, string fechaIngreso, string precio)
        {
            return cn.ModificarMaterial(codMaterial, cant, codUnidadMedida, codProv, fechaIngreso, precio);
        }
        public int eliminarMaterial(string Material)
        {
            return cn.eliminarMaterial(Material);
        }

    }
}
