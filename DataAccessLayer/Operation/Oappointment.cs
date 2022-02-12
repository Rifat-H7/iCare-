using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operation
{
    public class Oappointment
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True");
        public void insert(Eappointment eappointment)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Appointment_Table(DName,PName,Chamber,Visiting_day)values('" + eappointment.DName + "','" + eappointment.PName + "','" + eappointment.Chamber + "','" + eappointment.Visiting_day + "')", con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataAdapter show(string text)
        {

            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select PName,Visiting_day from Appointment_Table", con);
            con.Close();
            return sqlDataAdapter;

        }
        public string Show(string msg)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True");
            con.Open();
            string qr = "select * from Appointment_Table";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool recordfound = dr.Read();
            if (recordfound)
            {
                if (msg == "1") { return dr["DName"].ToString(); }
                else if (msg == "2") { return dr["Chamber"].ToString(); }
            }

            else
            {
                return "No data found";
            }
            return null;
        }
    }
}
