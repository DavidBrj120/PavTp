using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using PavTpGrupo11.Formularios;

namespace PavTpGrupo11.AccesoADatos


{
   public  class ConexionSQL
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);

        public int Login( string us, string pass )
        {
            int count;
            conexion.Open();
            string query = "Select Count(*) FROM Usuario WHERE Nombre = '"+us+ "'and Contraseña = '"+pass+"'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return count;
        }
        public DataTable ConsultarUsuarios()
        {
            string query = "SELECT * FROM Usuario";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }

        public int InsertarUsuarioU(string us, string contra)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Usuario(Nombre, Contraseña ) values('" + us + "', '" +  contra + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int EliminarUsuario(string nom)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Usuario WHERE Nombre = '" + nom + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int ModificarUsuario(string nom, string con)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Usuario SET Contraseña = '" + con + "' WHERE Nombre = '" + nom + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public DataTable ObtenerRepuestos()
        {
            string query = "SELECT * FROM REPUESTO";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }

        public int InsertarRepuesto(string cod, string nom)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into REPUESTO(Codigo_Repuesto, Nombre_Repuesto ) values('" + cod + "', '" + nom + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int EliminarRespuesto(int cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM REPUESTO WHERE Codigo_Repuesto = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int ModificarRepuesto(int cod, string nom)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE REPUESTO SET Nombre_Repuesto = '" + nom + "' WHERE Codigo_Repuesto = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        public DataTable ConsultarUsuariosDG()
        {
            string query = "SELECT * FROM Empleados";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public DataTable ConsultarBarriosDG()
        {
            string query = "SELECT * FROM Barrios";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public int InsertarUsuario(string cod, string nom, string tel, string doc, string calle, string nro, string barrio)

        {
                int flag = 0;
                conexion.Open();
                string query = "insert into Empleados(Cod_Empleado, Nombre, Telefono, Documento, calle, nro_Calle, id_barrio) values('" + cod + "', '" + nom + "', '" + tel + "', '" + doc + "', '" + calle + "', '" + nro + "', '" + barrio + "')";

                SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
                conexion.Close();
            return flag;
               
            
        }
        public int  EliminarEmpleado(string cod)
        {

            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Empleados WHERE Cod_Empleado = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int ModificarEmpleado(string cod, string nom, string tel, string doc, string calle, string nro, string barrio)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Empleados SET Nombre = '" + nom + "', Telefono = '" + tel + "', Documento = '" + doc + "', calle =  '" + calle + "', nro_calle =  '" + nro + "', id_barrio = '" + barrio + "' WHERE Cod_Empleado = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        public bool InsertarBarrio(string id, string nom)

        {
            bool resultado = false;

            try
            {
                conexion.Open();
                string query = "insert into Barrios(id_barrio, nombre_barrio) values('" + id + "', '" + nom + "')";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                
                resultado= true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public int ModificarBarrio( string dni, string nom)

        {
            int resultado = 0;
            try
            {
                conexion.Open();
                string query = "UPDATE Barrios SET nombre_barrio = '" + nom + "' where id_barrio = '" + dni + "'";

                SqlCommand cmd = new SqlCommand(query, conexion);
                resultado =cmd.ExecuteNonQuery();

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            
          


        }
        public int EliminarBarrio(string id)

        {
            int flag = 0;

            try
            {
                conexion.Open();
                string query = "DELETE FROM Barrios WHERE id_barrio = '" + id + "'";

                SqlCommand cmd = new SqlCommand(query, conexion);
                flag = cmd.ExecuteNonQuery();
                return flag;
                 
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conexion.Close();
            }
            
           


        }
        // proveedores david
        public DataTable ConsultarProveedoresDG()
        {
            string query = "SELECT * FROM Proveedor";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarProveedor(string cod, string nom, string tel, string mail, string calle, string nro, string barrio)

        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Proveedor(Cod_Proveedor, Nombre, Telefono, Mail, Calle, nro_Calle, id_barrio) values('" + cod + "', '" + nom + "', '" + tel + "', '" + mail + "', '" + calle + "', '" + nro + "', '" + barrio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }

        public int ModificarProveedor(string cod, string nom, string tel, string mail, string calle, string nro, string barrio)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Proveedor SET Nombre = '" + nom + "', Telefono = '" + tel + "', Mail = '" + mail + "', Calle =  '" + calle + "', nro_calle =  '" + nro + "', id_barrio = '" + barrio + "' WHERE Cod_Proveedor = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int EliminarProveedor(string cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Proveedor WHERE Cod_Proveedor = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        // Obra david
        public DataTable ConsultarObrasDG()
        {
            string query = "SELECT * FROM Obras";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarObra(string cod, string nomObra, string calle, string nro, string barrio)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Obras(codigo_obra, nombre_Obra, calle, nro_Calle, id_barrio) values('" + cod + "','" + nomObra + "', '" + calle + "', '" + nro + "', '" + barrio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }

        public int ModificarObra(string cod, string nomObra, string calle, string nro, string barrio)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Obras SET nombre_Obra = '" + nomObra + "', Calle =  '" + calle + "', nro_calle =  '" + nro + "', id_barrio = '" + barrio + "' WHERE codigo_Obra = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int EliminarObra(string cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Obras WHERE codigo_Obra = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }


        public DataTable ObtenerCamiones()
        {
            string query = "SELECT * FROM Camiones";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarCamion(string patente, string marca, string mod, string cap)

        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Camiones(Patente, Marca_Camión, Año_Modelo, Capacidad ) values('" + patente + "', '" + marca + "', '" + mod + "', '" + cap + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int eliminarCamion(string patente)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Camiones WHERE Patente = '" + patente + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int ModificarCamion(string patente, string marca, string mod, string cap)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Camiones SET Marca_Camión = '" + marca + "', Año_Modelo =  '" + mod + "', Capacidad =  '" + cap + "' WHERE Patente = '" + patente + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        // Materiales David 
        public DataTable ConsultarMaterialesDG()
        {
            string query = "SELECT * FROM Materiales";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        public int InsertarMaterial(string codMaterial, string cant, string codUnidadMedida, string codProv, string fechaIngreso, string precio)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Materiales(Codigo_Material, Cantidad, Cod_Unidad_Medida, Cod_Proveedor, Fecha_Ingreso, precio) values('" + codMaterial + "','" + cant + "', '" + codUnidadMedida + "', '" + codProv + "', '" + fechaIngreso + "', '" + precio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }
        public int ModificarMaterial(string codMaterial, string cant, string codUnidadMedida, string codProv, string fechaIngreso, string precio)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Materiales SET Cantidad = '" + cant + "', Cod_Unidad_Medida =  '" + codUnidadMedida + "', Cod_Proveedor =  '" + codProv + "', Fecha_Ingreso = '" + fechaIngreso + "', precio = '"+ precio + "' WHERE Codigo_Material = '" + codMaterial + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int eliminarMaterial(string Material)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Materiales WHERE Codigo_Material = '" + Material + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
    }

}
