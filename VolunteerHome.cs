using DataAccessLayer.Entity;
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
    public partial class VolunteerHome : Form
    {
        public VolunteerHome(string msg)
        {
            InitializeComponent();
            vem.Text = msg;
            Ohospital ohospital = new Ohospital();
            lbhos.Text = ohospital.Show("1",msg);
            lboca.Text = ohospital.Show("2", msg);
            lbbed.Text = ohospital.Show("3", msg);
            lbam.Text = ohospital.Show("4", msg);
            ap.Text = ohospital.Show("5", msg);
            an.Text = ohospital.Show("6", msg);
            abp.Text = ohospital.Show("7", msg);
            abn.Text = ohospital.Show("8", msg);
            bp.Text = ohospital.Show("9", msg);
            bn.Text = ohospital.Show("10", msg);
            op.Text = ohospital.Show("11", msg);
            on.Text = ohospital.Show("12", msg);
            if (lbhos.Text=="No data found")
            {
                inbtn.Visible = true;
                txthname.Visible = true;
                comboloc.Visible = true;
                txtap.Visible = true;
                txtan.Visible = true;
                txtbp.Visible = true;
                txtbn.Visible = true;
                txtabp.Visible = true;
                txtabn.Visible = true;
                txtop.Visible = true;
                txton.Visible = true;
                txtbed.Visible = true;
                txtam.Visible = true;
                lbam.Visible = false;
                lbbed.Visible = false;
            }
            else
            {
                edbtn.Visible = true;
            }
        }
        Ehospital ehospital = new Ehospital();
        Ohospital ohospital = new Ohospital();

        private void edbtn_Click(object sender, EventArgs e)
        {
            inbtn.Visible = false;
            txthname.Visible = true;
            comboloc.Visible = true;
            txtap.Visible = true;
            txtan.Visible = true;
            txtbp.Visible = true;
            txtbn.Visible = true;
            txtabp.Visible = true;
            txtabn.Visible = true;
            txtop.Visible = true;
            txton.Visible = true;
            txtbed.Visible = true;
            txtam.Visible = true;
            upbtn.Visible = true;
        }

        private void inbtn_Click(object sender, EventArgs e)
        {
            inbtn.Visible = false;
            txthname.Visible = false;
            comboloc.Visible = false;
            txtap.Visible = false;
            txtan.Visible = false;
            txtbp.Visible = false;
            txtbn.Visible = false;
            txtabp.Visible = false;
            txtabn.Visible = false;
            txtop.Visible = false;
            txton.Visible = false;
            txtbed.Visible = false;
            txtam.Visible = false;
            lbam.Visible = true;
            lbbed.Visible = true;
            edbtn.Visible = true;

            ehospital.VName = vem.Text;
            ehospital.HName = txthname.Texts;
            ehospital.Location = comboloc.Texts;
            ehospital.Bed = Convert.ToInt32(txtbed.Texts);
            ehospital.Ambulance = Convert.ToInt32(txtam.Texts);
            ehospital.Apos = Convert.ToInt32(txtap.Texts);
            ehospital.Aneg = Convert.ToInt32(txtan.Texts);
            ehospital.ABpos = Convert.ToInt32(txtabp.Texts);
            ehospital.ABneg = Convert.ToInt32(txtabn.Texts);
            ehospital.Bpos = Convert.ToInt32(txtbp.Texts);
            ehospital.Bneg = Convert.ToInt32(txtbn.Texts);
            ehospital.Opos = Convert.ToInt32(txtop.Texts);
            ehospital.Oneg = Convert.ToInt32(txton.Texts);
            ohospital.insert(ehospital);
            inbtn.Visible = false;
            lbhos.Text = ohospital.Show("1", vem.Text);
            lboca.Text = ohospital.Show("2", vem.Text);
            lbbed.Text = ohospital.Show("3", vem.Text);
            lbam.Text = ohospital.Show("4", vem.Text);
            ap.Text = ohospital.Show("5", vem.Text);
            an.Text = ohospital.Show("6", vem.Text);
            abp.Text = ohospital.Show("7", vem.Text);
            abn.Text = ohospital.Show("8", vem.Text);
            bp.Text = ohospital.Show("9", vem.Text);
            bn.Text = ohospital.Show("10", vem.Text);
            op.Text = ohospital.Show("11", vem.Text);
            on.Text = ohospital.Show("12", vem.Text);
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            upbtn.Visible = false;
            txthname.Visible = false;
            comboloc.Visible = false;
            txtap.Visible = false;
            txtan.Visible = false;
            txtbp.Visible = false;
            txtbn.Visible = false;
            txtabp.Visible = false;
            txtabn.Visible = false;
            txtop.Visible = false;
            txton.Visible = false;
            txtbed.Visible = false;
            txtam.Visible = false;
            lbam.Visible = true;
            lbbed.Visible = true;

            Ehospital ehospital = new Ehospital();
            Ohospital ohospital = new Ohospital();
            ehospital.HName = lbhname.Text;
            ehospital.Bed = Convert.ToInt32(txtbed.Texts);
            ehospital.Ambulance = Convert.ToInt32(txtam.Texts);
            ehospital.Apos = Convert.ToInt32(txtap.Texts);
            ehospital.Aneg = Convert.ToInt32(txtan.Texts);
            ehospital.Bpos = Convert.ToInt32(txtbp.Texts);
            ehospital.Bneg = Convert.ToInt32(txtbn.Texts);
            ehospital.ABpos = Convert.ToInt32(txtabp.Texts);
            ehospital.ABneg = Convert.ToInt32(txtabn.Texts);
            ehospital.Opos = Convert.ToInt32(txtop.Texts);
            ehospital.Oneg = Convert.ToInt32(txton.Texts);
            ohospital.update(ehospital);

            lbhos.Text = ohospital.Show("1", vem.Text);
            lboca.Text = ohospital.Show("2", vem.Text);
            lbbed.Text = ohospital.Show("3", vem.Text);
            lbam.Text = ohospital.Show("4", vem.Text);
            ap.Text = ohospital.Show("5", vem.Text);
            an.Text = ohospital.Show("6", vem.Text);
            abp.Text = ohospital.Show("7", vem.Text);
            abn.Text = ohospital.Show("8", vem.Text);
            bp.Text = ohospital.Show("9", vem.Text);
            bn.Text = ohospital.Show("10", vem.Text);
            op.Text = ohospital.Show("11", vem.Text);
            on.Text = ohospital.Show("12", vem.Text);
        }
    }
}
