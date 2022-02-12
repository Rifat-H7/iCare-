using DataAccessLayer.Entity;
using DataAccessLayer.Opertation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace iCare
{
    public partial class logsign : Form
    {
        public logsign()
        {
            InitializeComponent();
        }

        private void lbreg_Click(object sender, EventArgs e)
        {
            lbreg.ForeColor = ColorTranslator.FromHtml("0x75D4D0");
            lblog.ForeColor = Color.Black;
            selectp.Visible = true;
            logp.Visible = false;
            lblog.ForeColor = Color.Silver;

        }

        private void lblog_Click(object sender, EventArgs e)
        {
            patientp.Visible = false;
            selectp.Visible = false;
            logp.Visible = true;
            lbreg.ForeColor = Color.Black;
            lblog.ForeColor = ColorTranslator.FromHtml("0x75D4D0");
            selectp.Visible = false;
            logp.Visible = true;
            patientp.Visible = false;
            label3.Text = "Patient Signup";
            txtlicense.Visible = false;
            txtaddress.Visible = true;
            lbreg.ForeColor = Color.Silver;

        }

        private void patientbtn_Click(object sender, EventArgs e)
        {
            patientp.Visible = true;
            selectp.Visible = false;
            logp.Visible = false;
           
        }

        private void docbtn_Click(object sender, EventArgs e)
        {
            label3.Text = "Doctor Signup";
            patientp.Visible = true;
            txtaddress.Visible = false;
            txtlicense.Visible = true;
            selectp.Visible = false;
        }

        private void volbtn_Click(object sender, EventArgs e)
        {
            label3.Text = "Volunteer Signup";
            patientp.Visible = true;
            txtlicense.Visible = false;
            txtaddress.Visible = true;
            selectp.Visible = false;

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            Regex regex1 = new Regex("^[a-zA-Z]+[a-zA-Z0-9]+[[a-zA-Z0-9-_.!#$%'*+/=?^]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
            if (!regex1.IsMatch(txtemail.Texts))
            {
                lbsux.Visible = true;
                lbsux.ForeColor = Color.Red;
                lbsux.Text = "Wrong email address";
            }
            else
            {
                if (txtname.Texts == " " || txtemail.Texts == " " || txtphone.Texts == " " || txtpass.Texts == " " || txtaddress.Texts == " " || malerb.Checked == true || femalerb.Checked == true || bgcombo.Texts == " ")
                {
                    lbsux.Visible = true;
                    lbsux.ForeColor = ColorTranslator.FromHtml("0x75D4D0");
                    lbsux.Location = new Point(79, 344);
                    lbsux.Text = "Account Creation Successfull";


                    if (label3.Text == "Patient Signup")

                    {
                        int age = DateTime.Today.Year - dtage.Value.Year;
                        Epatient epatient = new Epatient();
                        epatient.Name = txtname.Texts;
                        epatient.Email = txtemail.Texts;
                        epatient.Age = age;
                        epatient.Address = txtaddress.Texts;
                        if (malerb.Checked == true)
                        {
                            epatient.Gender = malerb.Text;
                        }
                        else
                        {
                            epatient.Gender = femalerb.Text;
                        }
                        epatient.Phone_Number = txtphone.Texts;
                        epatient.Blood_Group = bgcombo.Texts;
                        epatient.Password = txtpass.Texts;
                        Opatient opetient = new Opatient();
                        opetient.insert(epatient);
                    }
                    else if (label3.Text == "Doctor Signup")
                    {
                        int age = DateTime.Today.Year - dtage.Value.Year;
                        Edoctor edoctor = new Edoctor();
                        edoctor.Name = txtname.Texts;
                        edoctor.Email = txtemail.Texts;
                        edoctor.Age = age;
                        if (malerb.Checked == true)
                        {
                            edoctor.Gender = malerb.Text;
                        }
                        else
                        {
                            edoctor.Gender = femalerb.Text;
                        }
                        edoctor.Blood_Group = bgcombo.Texts;
                        edoctor.Phone_Number = txtphone.Texts;
                        edoctor.License_Number = txtlicense.Texts;
                        edoctor.Password = txtpass.Texts;
                        Odoctor odoctor = new Odoctor();
                        odoctor.insert(edoctor);
                    }
                    else if (label3.Text == "Volunteer Signup")
                    {
                        int age = DateTime.Today.Year - dtage.Value.Year;
                        Evolunteer evolunteer = new Evolunteer();
                        evolunteer.Name = txtname.Texts;
                        evolunteer.Email = txtemail.Texts;
                        evolunteer.Age = age;
                        evolunteer.Address = txtaddress.Texts;
                        if (malerb.Checked == true)
                        {
                            evolunteer.Gender = malerb.Text;
                        }
                        else
                        {
                            evolunteer.Gender = femalerb.Text;
                        }
                        evolunteer.Phone_Number = txtphone.Texts;
                        evolunteer.Blood_Group = bgcombo.Texts;
                        evolunteer.Password = txtpass.Texts;
                        Ovolunteer ovolunteer = new Ovolunteer();
                        ovolunteer.insert(evolunteer);
                    }

                }
                else
                {
                    lbsux.Visible = true;
                    lbsux.ForeColor = Color.Red;
                    lbsux.Text = "Please fill all the fields";
                }

            }
           
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            if (prb.Checked == true)
            {               
                 SqlConnection scn = new SqlConnection();
                 scn.ConnectionString = @"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True";
                 SqlCommand scmd = new SqlCommand("select count (*) as cnt from patient_Table where Email=@usr and Password=@pwd", scn);
                 scmd.Parameters.Clear();
                 scmd.Parameters.AddWithValue("@usr", txtlogemail.Texts);
                 scmd.Parameters.AddWithValue("@pwd", txtlogpass.Texts);
                 scn.Open();
                 
                if (scmd.ExecuteScalar().ToString() == "1")
                 {
                     wc.Visible = false;
                     PatientHome ph = new PatientHome(txtlogemail.Texts);
                     ph.Show();     
                 }
                 else
                 {
                     wc.Visible = true;
                 }
                 scn.Close();
                
            }
            
            else if (drb.Checked == true)
            {
                SqlConnection scn = new SqlConnection();
                scn.ConnectionString = @"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True";
                SqlCommand scmd = new SqlCommand("select count (*) as cnt from doctor_Table where Email=@usr and Password=@pwd", scn);
                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@usr", txtlogemail.Texts);
                scmd.Parameters.AddWithValue("@pwd", txtlogpass.Texts);
                scn.Open();
                if (scmd.ExecuteScalar().ToString() == "1")
                {
                    wc.Visible = false;
                    DoctorHome dc = new DoctorHome(txtlogemail.Texts);
                    dc.Show();
                }
                else
                {
                    wc.Visible = true;
                }
                scn.Close();
            }
            else if (vrb.Checked == true)
            {
                SqlConnection scn = new SqlConnection();
                scn.ConnectionString = @"Data Source=DESKTOP-P6MO2V1;Initial Catalog=icare;Integrated Security=True";
                SqlCommand scmd = new SqlCommand("select count (*) as cnt from Volunteer_Table where Email=@usr and Password=@pwd", scn);
                scmd.Parameters.Clear();
                scmd.Parameters.AddWithValue("@usr", txtlogemail.Texts);
                scmd.Parameters.AddWithValue("@pwd", txtlogpass.Texts);
                scn.Open();
                if (scmd.ExecuteScalar().ToString() == "1")
                {
                    wc.Visible = false;
                    VolunteerHome vh = new VolunteerHome(txtlogemail.Texts);
                    vh.Show();
                }
                else
                {
                    wc.Visible = true;
                }
                scn.Close();
            }
            else if (txtlogemail.Texts=="rifathasansakil@aiub.edu" && txtlogpass.Texts == "12345")
            {
                AdminHome ah = new AdminHome();
                ah.Show();
            }
           
            
        }
    }
}
