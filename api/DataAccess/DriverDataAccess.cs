using api.Models;
using MySql.Data.MySqlClient;

namespace api.DataAccess
{
    public class DriverDataAccess
    {
        public List<Drivers> GetAll() {
            List<Drivers> drivers = new List<Drivers>();
            ConnectionString cs = new ConnectionString();
            using var con = new MySqlConnection(cs.cs);
            con.Open();

            string stm = "SELECT * FROM Drivers";
            MySqlCommand cmd = new MySqlCommand(stm, con);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read()) {
                Console.WriteLine(rdr.GetInt32(0) + " " + rdr.GetString(1));
                Drivers newDriver = new Drivers(){Id = rdr.GetInt32(0), Name = rdr.GetString(1), DateHired = rdr.GetDateTime(2), Rating = rdr.GetInt32(3), Active = rdr.GetBoolean(4)};
                drivers.Add(newDriver);
            }

            con.Close();

            return drivers;
        }
    }
}