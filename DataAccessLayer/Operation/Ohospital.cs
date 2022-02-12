using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Opertation
{
    public class Ohospital
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True");
        public void insert(Ehospital ehospital)
        {
          
            con.Open();
            SqlCommand command = new SqlCommand("insert into Hospital_Table(VName,HName,Location,Bed,Ambulance,Apos,Aneg,ABpos,ABneg,Bpos,Bneg,Opos,Oneg)values('" + ehospital.VName + "','" + ehospital.HName + "','" + ehospital.Location + "','" + ehospital.Bed + "','" + ehospital.Ambulance + "','" + ehospital.Apos + "','" + ehospital.Aneg + "','" + ehospital.ABpos + "','" + ehospital.ABneg + "','" + ehospital.Bpos + "','" + ehospital.Bneg + "','" + ehospital.Opos + "','" + ehospital.Oneg + "')", con);
            command.ExecuteNonQuery();
            con.Close();

        }
        
        public string Show(string msg, string vem)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True");

            con.Open();
            string qr = "select * from Hospital_Table Where VName='" + vem + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool recordfound = dr.Read();
            if(recordfound)
            {
                if (msg == "1") { return dr["HName"].ToString(); }
                else if (msg == "2") { return dr["Location"].ToString(); }
                else if (msg == "3") { return dr["Bed"].ToString(); }
                else if (msg == "4") { return dr["Ambulance"].ToString(); }
                else if (msg == "5") { return dr["Apos"].ToString(); }
                else if (msg == "6") { return dr["Aneg"].ToString(); }
                else if (msg == "7") { return dr["ABpos"].ToString(); }
                else if (msg == "8") { return dr["ABneg"].ToString(); }
                else if (msg == "9") { return dr["Bpos"].ToString(); }
                else if (msg == "10") { return dr["Bneg"].ToString(); }
                else if (msg == "11") { return dr["Opos"].ToString(); }
                else if (msg == "12") { return dr["Oneg"].ToString(); }
            }
           
            else
            {
                return "No data found";
            }
        
            return null;
      

        }
        public void update(Ehospital ehospital)
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Hospital_Table set Bed='" + ehospital.Bed + "',Ambulance='" + ehospital.Ambulance + "',Apos='" + ehospital.Apos + "',Aneg='" + ehospital.Aneg + "',ABpos='" + ehospital.ABpos + "',ABneg='" + ehospital.ABneg + "',Bpos='" + ehospital.Bpos + "',Bneg='" + ehospital.Bneg + "',Opos='" + ehospital.Opos + "',Oneg='" + ehospital.Oneg + "' where HName='" + ehospital.HName + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataAdapter Searchbed(string text)
        {

            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select HName,Bed from Hospital_Table where Location = '" + text + "'", con);
            con.Close();
            return sqlDataAdapter;

        }
        public SqlDataAdapter Searcham(string text)
        {

            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select HName,Ambulance from Hospital_Table where Location = '" + text + "'", con);
            con.Close();
            return sqlDataAdapter;

        }
        public SqlDataAdapter Searchbg(string text)
        {

            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select HName,Apos,Aneg,ABpos,ABneg,Bpos,Bneg,Opos,Oneg from Hospital_Table where Location = '" + text + "'", con);
            con.Close();
            return sqlDataAdapter;

        }
    }
}
