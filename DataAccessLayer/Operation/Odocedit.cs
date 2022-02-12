using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operation
{
    public class Odocedit
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True");
        public void insert(Edocedit edocedit)
        {           
            con.Open();
            SqlCommand command = new SqlCommand("insert into docedit_Table(Name,Degree,Specialist,HName,Location,Visiting_day,Time)values('" + edocedit.Name + "','" + edocedit.Degree + "','" + edocedit.Specialist + "','" + edocedit.HName + "','" + edocedit.Location + "','" + edocedit.Visiting_day + "','" + edocedit.Time+ "')", con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public string Show(string msg,string nm)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True");
            con.Open();
            string qr = "select * from docedit_Table where Name='" + nm + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool recordfound = dr.Read();
            if (recordfound)
            {
                if (msg == "1") { return dr["Degree"].ToString(); }
                else if (msg == "2") { return dr["Specialist"].ToString(); }
                else if (msg == "3") { return dr["HName"].ToString(); }
                else if (msg == "4") { return dr["Location"].ToString(); }
                else if (msg == "5") { return dr["Visiting_day"].ToString(); }
                else if (msg == "6") { return dr["Time"].ToString(); }
            }

            else
            {
                return "No data found";
            }
            return null;
        }
        public void update(Edocedit edocedit)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update docedit_Table set Degree='" + edocedit.Degree + "',Specialist='" + edocedit.Specialist + "',HName='" + edocedit.HName + "',Location='" + edocedit.Location + "',Visiting_day='" + edocedit.Visiting_day + "',Time='" + edocedit.Time + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataAdapter Search(string loc, string sp)
        {

            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from docedit_Table where Location = '" + loc + "' and Specialist='" + sp + "'", con);
            con.Close();
            return sqlDataAdapter;

        }
    }
}
