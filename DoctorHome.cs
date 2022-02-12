using DataAccessLayer.Entity;
using DataAccessLayer.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCare
{
    public partial class DoctorHome : Form
    {
        string s;
        public DoctorHome(string msg)
        {
            
            InitializeComponent();
            Edoctor edoctor = new Edoctor();
            dem.Text = msg;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True");
            con.Open();
            string qr = "select Name from Doctor_Table where Email='" + msg + "'";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool recordfound = dr.Read();
            if (recordfound)
            {
                lbname.Text= dr["Name"].ToString(); 
            }
            lbdeg.Text = odocedit.Show("1", lbname.Text);
            lbsp.Text = odocedit.Show("2", lbname.Text);
            lbchm.Text = odocedit.Show("3", lbname.Text);
            lbloc.Text = odocedit.Show("4", lbname.Text);
            vt.Text = odocedit.Show("5", lbname.Text);
            tv.Text = odocedit.Show("6", lbname.Text);
           
        }

        private void edbtn_Click(object sender, EventArgs e)
        {
            To.Visible = true;
            panel2.Visible = true;
            appn.Visible = false;
            edbtn.BackgroundColor = ColorTranslator.FromHtml("0x75D4D0");
            apbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            txtdeg.Visible = true;
            combosp.Visible = true;
            txtchm.Visible = true;
            comboloc.Visible = true;
            ckfr.Visible = true;
            ckst.Visible = true;
            cksn.Visible = true;
            ckmn.Visible = true;
            ckts.Visible = true;
            ckwd.Visible = true;
            ckth.Visible = true;
            combo1.Visible = true;
            combo2.Visible = true;
            comboampm.Visible = true;
            if (lbdeg.Text == "No data found")
            {
                inbtn.Visible = true;
                upbtn.Visible = false;
            }
            else
            {
                upbtn.Visible = true;
            }
        }
        Odocedit odocedit = new Odocedit();
        Edocedit edocedit = new Edocedit();

        private void apbtn_Click(object sender, EventArgs e)
        {
            apbtn.BackgroundColor = ColorTranslator.FromHtml("0x75D4D0");
            edbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            appn.Visible = true;

            Oappointment oappointment = new Oappointment();
            if (lbname.Text == oappointment.Show("1") && lbchm.Text==oappointment.Show("2"))
            {
                dataGridView1.Visible = true;
                SqlDataAdapter sqlDataAdapter = oappointment.show("1");
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                lbno.Visible = true;
            }
        }

        private void inbtn_Click(object sender, EventArgs e)
        {

            txtdeg.Visible = false;
            combosp.Visible = false;
            txtchm.Visible = false;
            comboloc.Visible = false;
            ckfr.Visible = false;
            ckst.Visible = false;
            cksn.Visible = false;
            ckmn.Visible = false;
            ckts.Visible = false;
            ckwd.Visible = false;
            ckth.Visible = false;
            combo1.Visible = false;
            combo2.Visible = false;
            comboampm.Visible = false;
            inbtn.Visible = false;
            vt.Visible = true;
            tv.Visible = true;
            edocedit.Name = lbname.Text;
            edocedit.Degree = txtdeg.Texts;
            edocedit.Specialist = combosp.Texts;
            edocedit.HName = txtchm.Texts;
            edocedit.Location = comboloc.Texts;
                 
            for(int i=0; i<1; i++)
            {
                if (ckfr.Checked == true)
                {
                    s += ckfr.Text;
                }
                if (ckst.Checked == true)
                {
                    s += ckst.Text;

                }
                if (cksn.Checked == true)
                {
                    s += cksn.Text;

                }
                if (ckmn.Checked == true)
                {
                    s += ckmn.Text;

                }
                if (ckts.Checked == true)
                {
                    s += ckts.Text;

                }
                if (ckwd.Checked == true)
                {
                    s += ckwd.Text;

                }
                if (ckth.Checked == true)
                {
                    s += ckth.Text;
                }
                edocedit.Visiting_day = s;
            }
            edocedit.Time = combo1.Texts + " To " + combo2.Texts + " " + comboampm.Texts;
            odocedit.insert(edocedit);          
            inbtn.Visible = false;
            lbdeg.Text = odocedit.Show("1", lbname.Text);
            lbsp.Text = odocedit.Show("2", lbname.Text);
            lbchm.Text = odocedit.Show("3", lbname.Text);
            lbloc.Text = odocedit.Show("4", lbname.Text);
            vt.Text = odocedit.Show("5", lbname.Text);
            tv.Text = odocedit.Show("6", lbname.Text);
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            txtdeg.Visible = false;
            combosp.Visible = false;
            txtchm.Visible = false;
            comboloc.Visible = false;
            ckfr.Visible = false;
            ckst.Visible = false;
            cksn.Visible = false;
            ckmn.Visible = false;
            ckts.Visible = false;
            ckwd.Visible = false;
            ckth.Visible = false;
            combo1.Visible = false;
            combo2.Visible = false;
            comboampm.Visible = false;

            edocedit.Degree = txtdeg.Texts;
            edocedit.Specialist = combosp.Texts;
            edocedit.HName = txtchm.Texts;
            edocedit.Location = comboloc.Texts;
            edocedit.Time = combo1.Texts + " To " + combo2.Texts + " " + comboampm.Texts;
            for (int i = 0; i < 1; i++)
            {
                if (ckfr.Checked == true)
                {
                    s += ckfr.Text;
                }
                if (ckst.Checked == true)
                {
                    s += ckst.Text;

                }
                if (cksn.Checked == true)
                {
                    s += cksn.Text;

                }
                if (ckmn.Checked == true)
                {
                    s += ckmn.Text;

                }
                if (ckts.Checked == true)
                {
                    s += ckts.Text;

                }
                if (ckwd.Checked == true)
                {
                    s += ckwd.Text;

                }
                if (ckth.Checked == true)
                {
                    s += ckth.Text;
                }
                edocedit.Visiting_day = s;
            }
            odocedit.update(edocedit);
            lbdeg.Text = odocedit.Show("1", lbname.Text);
            lbsp.Text = odocedit.Show("2", lbname.Text);
            lbchm.Text = odocedit.Show("3", lbname.Text);
            lbloc.Text = odocedit.Show("4", lbname.Text);
            vt.Text = odocedit.Show("5", lbname.Text);
            tv.Text = odocedit.Show("6", lbname.Text);

        }   

    }
}
