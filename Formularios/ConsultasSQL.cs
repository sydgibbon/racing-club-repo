using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Formularios
{
    class ConsultasSQL
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True");
        private DataSet ds;

        public DataTable mostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from alumno", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public DataTable Buscar(String nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from alumno where nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public bool Insertar(String nombre, String apellido, String fechaNacimiento, String codtipoDoc, String nroDoc, String calle, String nroCalle, String piso, String departamento, String codBarrio, String codCategoria, String codEstado, String sexo, String fechaAlta, String fechaBaja, String codtipoSocio)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format("insert into alumno values '{0}', '{1}', '{2}', {3}, {4}, '{5}', {6}, {7}, '{8}', {9}, {10}, {11}, '{12}', '{13}', '{14}', '{15}', {16}", new String[] { nombre, apellido, fechaNacimiento, codtipoDoc, nroDoc, calle, nroCalle, piso, departamento, codBarrio, codCategoria, codEstado, sexo, fechaAlta, fechaBaja, codtipoSocio }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
        public bool Eliminar(String codtipoDoc, String nroDoc)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format("delete from alumno where cod_tipoDoc = {0} AND nroDoc = {1}",new string[] {codtipoDoc, nroDoc}), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
        public bool Actualizar(String nombre, String apellido, String fechaNacimiento, String codtipoDoc, String nroDoc, String calle, String nroCalle, String piso, String departamento, String codBarrio, String codCategoria, String codEstado, String sexo, String fechaAlta, String fechaBaja, String codtipoSocio)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format("update alumno set nombre = '{0}', apellido = '{1}', fechaNacimiento = '{3}', codtipoDoc = {4}, nroDoc = {5}, calle = '{6}', nroCalle = {7}, piso = {8}, departamento = '{9}', codBarrio = {10}, codCategoria = {11}, codEstado = {12}, sexo = '{13}', fechaAlta = '{14}', fechaBaja = '{15}', codtipoSocio = {16}", new String[] { nombre, apellido, fechaNacimiento, codtipoDoc, nroDoc, calle, nroCalle, piso, departamento, codBarrio, codCategoria, codEstado, sexo, fechaAlta, fechaBaja, codtipoSocio }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }

    }
}
