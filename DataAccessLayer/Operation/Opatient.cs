using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Opertation
{
    public class Opatient
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True");
        public void insert(Epatient epatient)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("insert into patient_Table(Name,Email,Age,Address,Gender,Phone_Number,Blood_Group,Password)values('" + epatient.Name + "','" + epatient.Email + "','" + epatient.Age + "','" + epatient.Address + "','" + epatient.Gender + "','" + epatient.Phone_Number + "','" + epatient.Blood_Group + "','" + epatient.Password + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public SqlDataAdapter Search(string text)
        {

            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Patient_Table where Email = '" + text + "'", connection);
            connection.Close();
            return sqlDataAdapter;

        }
        public void delete(string text)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("delete from patient_Table where Email = '" + text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }


    }
}