using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Opertation
{
    public class Ovolunteer
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True");
        public void insert(Evolunteer evolunteer)
        {
            
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Volunteer_Table(Name,Email,Age,Address,Gender,Phone_Number,Blood_Group,Password)values('" + evolunteer.Name + "','" + evolunteer.Email + "','" + evolunteer.Age + "','" + evolunteer.Address + "','" + evolunteer.Gender + "','" + evolunteer.Phone_Number + "','" + evolunteer.Blood_Group + "','" + evolunteer.Password + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public SqlDataAdapter Search(string text)
        {

            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Volunteer_Table where Email = '" + text + "'", connection);
            connection.Close();
            return sqlDataAdapter;

        }
        public void delete(string text)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("delete from Volunteer_Table where Email = '" + text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
   

    }
}