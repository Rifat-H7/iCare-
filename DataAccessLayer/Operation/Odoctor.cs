using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Opertation
{
    public class Odoctor
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True");
        public void insert(Edoctor edoctor)
        {
            
            connection.Open();
            SqlCommand command = new SqlCommand("insert into doctor_Table(Name,Email,Age,Gender,Blood_Group,Phone_Number,License_Number,Password)values('" + edoctor.Name + "','" + edoctor.Email + "','" + edoctor.Age + "','" + edoctor.Gender + "','"+edoctor.Blood_Group+"','" + edoctor.Phone_Number + "','" + edoctor.License_Number + "','" + edoctor.Password + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public SqlDataAdapter Search(string text)
        {

            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Doctor_Table where Email = '" + text + "'", connection);
            connection.Close();
            return sqlDataAdapter;

        }
        public void delete(string text)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("delete from Doctor_Table where Email = '" + text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

    }
}