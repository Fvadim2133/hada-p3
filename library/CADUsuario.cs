using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class CADUsuario
    {

        private string constring;

        public CADUsuario(){
            constring = ConfigurationManager.ConnectionStrings["Batabase"].ToString();
        }


        public bool readUsuario(ENUsuario en)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();

                string cmd = $"Select * From [dbo].[Usuarios] Where nif = '´{en.nif}' ";
                SqlCommand com = new SqlCommand(cmd, c);
                SqlDataReader search = com.ExecuteReader();

                search.Read();

                if (search["nif"].ToString() == en.nif)
                {
                    en.nombre = search["nombre"].ToString();
                    en.nif = search["nif"].ToString();
                    en.edad = int.Parse(search["edad"].ToString());
                }
                else return false;

                search.Close();
                c.Close();

                return true;
            }
            catch (SqlException e) { Console.WriteLine($"createUsuario_SqlException: {e.Message}"); }
            catch (Exception e) { Console.WriteLine($"createUsuario_Exception: {e.Message}"); }

            return false;
        }

        public bool readNextUsuario(ENUsuario en)
        {
            return true;
        }

        public bool readPrevUsuario(ENUsuario en)
        {
            return true;
        }

        public bool readFirstUsuario(ENUsuario en)
        {
            return true;
        }

        /*
        public bool createUsuario(ENUsuario en)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();

                string cmd = $"Insert INTO [dbo].[Usuarios] (nombre, nif, edad) VALUES ('{en.nombre}','{en.nif}',{en.edad})";
                SqlCommand com = new SqlCommand(cmd, c);
                com.ExecuteNonQuery();
                c.Close();

                return true;
            }
            catch (SqlException e){ Console.WriteLine($"createUsuario_SqlException: {e.Message}");}
            catch (Exception e){Console.WriteLine($"createUsuario_Exception: {e.Message}");}
           
            return false;
        }*/

        private bool conectaCon(string cmd)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();

                SqlCommand com = new SqlCommand(cmd, c);
                com.ExecuteNonQuery();

                c.Close();

                return true;
            }
            catch (SqlException e) { Console.WriteLine($"createUsuario_SqlException: {e.Message}"); }
            catch (Exception e) { Console.WriteLine($"createUsuario_Exception: {e.Message}"); }

            return false;

        }

        public bool createUsuario(ENUsuario en)
        {
            return conectaCon($"Insert INTO [dbo].[Usuarios] (nombre, nif, edad) VALUES ('{en.nombre}','{en.nif}',{en.edad})");

        }

        public bool updateUsuario(ENUsuario en)
        {
            return conectaCon($"UPDATE [dbo].[Usuarios] SET nombre= '{en.nombre}' ,edad={en.edad} WHERE nif = '{en.nif}'");
        }

        /*
        public bool updateUsuario(ENUsuario en)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();

                string cmd = $"UPDATE [dbo].[Usuarios] SET nombre= '{en.nombre}' ,edad={en.edad} WHERE nif = '{en.nif}'";
                SqlCommand com = new SqlCommand(cmd, c);
                com.ExecuteNonQuery();
                
                c.Close();

                return true;
            }
            catch (SqlException e) { Console.WriteLine($"createUsuario_SqlException: {e.Message}"); }
            catch (Exception e) { Console.WriteLine($"createUsuario_Exception: {e.Message}"); }

            return false;
        }*/

        public bool deleteUsuario(ENUsuario en)
        {
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();

                string cmd = $"DELETE FROM [dbo].[Usuarios] WHERE nif = '{en.nif}'";
                SqlCommand com = new SqlCommand(cmd, c);
                com.ExecuteNonQuery();

                c.Close();

                return true;
            }
            catch (SqlException e) { Console.WriteLine($"createUsuario_SqlException: {e.Message}"); }
            catch (Exception e) { Console.WriteLine($"createUsuario_Exception: {e.Message}"); }

            return false;
        }

    }
}
