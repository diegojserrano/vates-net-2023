using System.Data;
using System.Data.SqlClient;


SqlConnection c = new SqlConnection("Server=localhost;Database=Personas;User Id=sa;Password=sa2k19..;");
try
{
    c.Open();
    
}
catch (System.Data.SqlClient.SqlException e)
{
    System.Console.WriteLine(c.ToString());
    System.Console.WriteLine(e.Message);
}
System.Console.WriteLine(c.State);


SqlCommand comm = c.CreateCommand();
comm.CommandText = "select * from Personas";
SqlDataReader dr = comm.ExecuteReader();
int cant = 0;


while(dr.Read()) { // Una vuelta por cada fila
    int doc = dr.GetInt32("documento");
    string nom = dr.GetString("nombre");
    string ape = dr.GetString("apellido");
    int edad = dr.GetInt32("edad");
    cant++;
    System.Console.WriteLine($"{doc} {nom} {ape} {edad}");
}


dr.Close();

c.Close();


System.Console.WriteLine($"Se leyeron {cant} personas");