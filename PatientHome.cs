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
using DataAccessLayer.Operation;
using DataAccessLayer.Entity;
using DataAccessLayer.Opertation;

namespace iCare
{
    public partial class PatientHome : Form
    {
        public PatientHome(string msg)
        {
            logsign lem = new logsign();
            InitializeComponent();
            em.Text = msg;

        }

       

        private void bedbtn_Click(object sender, EventArgs e)
        {
            bedbtn.BackgroundColor = ColorTranslator.FromHtml("0x75D4D0");
            ambulancebtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            bloodbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            apbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            app.Visible = false;
            bedp.Visible = true;
            amp.Visible = false;
            bgp.Visible = false;

        }

        private void ambulancebtn_Click(object sender, EventArgs e)
        {
            ambulancebtn.BackgroundColor = ColorTranslator.FromHtml("0x75D4D0");
            bloodbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            apbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            bedbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            amp.Visible = true;
            app.Visible = false;
            bedp.Visible = false;
            bgp.Visible = false;

        }

        private void bloodbtn_Click(object sender, EventArgs e)
        {
            bloodbtn.BackgroundColor = ColorTranslator.FromHtml("0x75D4D0");
            apbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            bedbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            ambulancebtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            amp.Visible = false;
            bgp.Visible = true;
            app.Visible = false;
            bedp.Visible = false;

        }

        private void apbtn_Click(object sender, EventArgs e)
        {
            apbtn.BackgroundColor = ColorTranslator.FromHtml("0x75D4D0");
            bedbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            ambulancebtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            bloodbtn.BackgroundColor = ColorTranslator.FromHtml("0xF0F0F0");
            app.Visible = true;
            bedp.Visible = false;
            amp.Visible = false;
            bgp.Visible = false;

        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            Odocedit odocedit = new Odocedit();
            SqlDataAdapter sqlDataAdapter = odocedit.Search(comboloc.Texts,combosp.Texts);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Visible = true;
        }

        private void tkabtn_Click(object sender, EventArgs e)
        {
            apcn.Visible = true;
        }

        private void cnbtn_Click(object sender, EventArgs e)
        {
            Oappointment oappointment = new Oappointment();
            Eappointment eappointment = new Eappointment();
            
            eappointment.DName = txtdcn.Texts;
            eappointment.PName = txtptn.Texts;
            eappointment.Chamber = txtchm.Texts;
            eappointment.Visiting_day = combovisit.Texts;
            oappointment.insert(eappointment);
            lbap.Visible = true;
        }

        private void srchbedbtn_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            Ohospital ohospital = new Ohospital();
            SqlDataAdapter sqlDataAdapter = ohospital.Searchbed(combolocb.Texts);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;

        }

        private void srcham_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            Ohospital ohospital = new Ohospital();
            SqlDataAdapter sqlDataAdapter = ohospital.Searcham(comboam.Texts);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
        }

        private void srchbg_Click(object sender, EventArgs e)
        {
            dataGridView4.Visible = true;
            Ohospital ohospital = new Ohospital();
            SqlDataAdapter sqlDataAdapter = ohospital.Searchbg(combolocbg.Texts);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView4.DataSource = dataTable;
        }
    }
}
