using DataAccessLayer.Opertation;
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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            dltbtn.Visible = true;
            dataGridView1.Visible = true;
            if (ptrb.Checked == true)
            {
                Opatient opatient = new Opatient();
                SqlDataAdapter sqlDataAdapter = opatient.Search(txtemsr.Texts);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
            else if (docrb.Checked == true)
            {
                Odoctor odoctor = new Odoctor();
                SqlDataAdapter sqlDataAdapter = odoctor.Search(txtemsr.Texts);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
            else if (vrb.Checked == true)
            {
                Ovolunteer ovolunteer = new Ovolunteer();
                SqlDataAdapter sqlDataAdapter = ovolunteer.Search(txtemsr.Texts);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            lbdlt.Visible = true;
            dataGridView1.Visible = false;
            if (ptrb.Checked == true)
            {
                Opatient op = new Opatient();
                op.delete(txtemsr.Texts);
            }
            else if (docrb.Checked == true)
            {

                Odoctor odoctor = new Odoctor();
                odoctor.delete(txtemsr.Texts);

            }
            else if (vrb.Checked == true)
            {
                Ovolunteer ovolunteer = new Ovolunteer();
                ovolunteer.delete(txtemsr.Texts);
            }
        }
    }
}
