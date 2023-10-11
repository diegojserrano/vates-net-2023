using System.Data;
using System.Data.SqlClient;

namespace ADOConParametrosYMapeo
{
    public class GestorPersonas
    {
        private string CONN = "Server=SOL-DESKTOP\\SQLEXPRESS;Database=Prueba; User Id=SOL-DESKTOP\\Sol; Trusted_Connection=true;";

        public void Agregar(Persona nueva)
        {
            using (SqlConnection conn = new SqlConnection(CONN))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Personas(Nombre, Apellido, Edad, IdEstadoCivil) values(@Nombre, @Apellido, @Edad, @IdEstadoCivil)", conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar) { Value = nueva.Nombre });
                    cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.NVarChar) { Value = nueva.Apellido });
                    cmd.Parameters.Add(new SqlParameter("@Edad", SqlDbType.Int) { Value = nueva.Edad });
                    cmd.Parameters.Add(new SqlParameter("@IdEstadoCivil", SqlDbType.Int) { Value = nueva.EstadoCivil.Id });
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Persona> ObtenerTodos()
        {
            List<Persona> lista = new List<Persona>();
            using (SqlConnection conn = new SqlConnection(CONN))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT p.*, ec.Nombre as NombreEC FROM Personas p JOIN EstadosCiviles ec ON p.IdEstadoCivil = ec.Id", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EstadoCivil ec = new EstadoCivil((int)reader["IdEstadoCivil"], (string)reader["NombreEC"]);
                            Persona p = new Persona((int)reader["Id"], (string)reader["Nombre"], (string)reader["Apellido"], (int)reader["Edad"], ec);
                            lista.Add(p);
                        }
                    }
                }
            }

            return lista;
        }
        public List<EstadoCivil> ObtenerEstadosCiviles()
        {
            List<EstadoCivil> lista = new List<EstadoCivil>();
            using (SqlConnection conn = new SqlConnection(CONN))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM EstadosCiviles", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EstadoCivil ec = new EstadoCivil((int)reader["Id"], (string)reader["Nombre"]);
                            lista.Add(ec);
                        }
                    }
                }
            }

            return lista;
        }
        public void Modificar(Persona personaModificada)
        {
            // Modificar una persona en la BD
        }
        public void Eliminar()
        {
            // Eliminar una persona de la BD
        }
    }
}