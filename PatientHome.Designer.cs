
namespace iCare
{
    partial class PatientHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bloodbtn = new RHFactory_CustomUi.RH_Button();
            this.bedbtn = new RHFactory_CustomUi.RH_Button();
            this.ambulancebtn = new RHFactory_CustomUi.RH_Button();
            this.em = new System.Windows.Forms.Label();
            this.apbtn = new RHFactory_CustomUi.RH_Button();
            this.app = new System.Windows.Forms.Panel();
            this.apcn = new System.Windows.Forms.Panel();
            this.lbap = new System.Windows.Forms.Label();
            this.combovisit = new RHFactory_CustomUi.RH_ComboBox();
            this.txtptn = new RHFactory_CustomUi.RH_TextBox();
            this.txtchm = new RHFactory_CustomUi.RH_TextBox();
            this.txtdcn = new RHFactory_CustomUi.RH_TextBox();
            this.cnbtn = new RHFactory_CustomUi.RH_Button();
            this.tkabtn = new RHFactory_CustomUi.RH_Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.srchbtn = new RHFactory_CustomUi.RH_Button();
            this.combosp = new RHFactory_CustomUi.RH_ComboBox();
            this.comboloc = new RHFactory_CustomUi.RH_ComboBox();
            this.bedp = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.srchbedbtn = new RHFactory_CustomUi.RH_Button();
            this.combolocb = new RHFactory_CustomUi.RH_ComboBox();
            this.amp = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.srcham = new RHFactory_CustomUi.RH_Button();
            this.comboam = new RHFactory_CustomUi.RH_ComboBox();
            this.bgp = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.srchbg = new RHFactory_CustomUi.RH_Button();
            this.combolocbg = new RHFactory_CustomUi.RH_ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.app.SuspendLayout();
            this.apcn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bedp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.amp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.bgp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bloodbtn);
            this.panel1.Controls.Add(this.bedbtn);
            this.panel1.Controls.Add(this.ambulancebtn);
            this.panel1.Controls.Add(this.em);
            this.panel1.Controls.Add(this.apbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 502);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iCare.Properties.Resources._5964828_fever_healthcare_medical_patient_sick_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // bloodbtn
            // 
            this.bloodbtn.BackColor = System.Drawing.SystemColors.Control;
            this.bloodbtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bloodbtn.BorderColor = System.Drawing.SystemColors.Control;
            this.bloodbtn.BorderRadius = 10;
            this.bloodbtn.BorderSize = 0;
            this.bloodbtn.FlatAppearance.BorderSize = 0;
            this.bloodbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bloodbtn.ForeColor = System.Drawing.Color.Black;
            this.bloodbtn.Location = new System.Drawing.Point(12, 252);
            this.bloodbtn.Name = "bloodbtn";
            this.bloodbtn.Size = new System.Drawing.Size(149, 40);
            this.bloodbtn.TabIndex = 10;
            this.bloodbtn.Text = "Blood Bank";
            this.bloodbtn.TextColor = System.Drawing.Color.Black;
            this.bloodbtn.UseVisualStyleBackColor = false;
            this.bloodbtn.Click += new System.EventHandler(this.bloodbtn_Click);
            // 
            // bedbtn
            // 
            this.bedbtn.BackColor = System.Drawing.SystemColors.Control;
            this.bedbtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bedbtn.BorderColor = System.Drawing.SystemColors.Control;
            this.bedbtn.BorderRadius = 10;
            this.bedbtn.BorderSize = 0;
            this.bedbtn.FlatAppearance.BorderSize = 0;
            this.bedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bedbtn.ForeColor = System.Drawing.Color.Black;
            this.bedbtn.Location = new System.Drawing.Point(12, 160);
            this.bedbtn.Name = "bedbtn";
            this.bedbtn.Size = new System.Drawing.Size(149, 40);
            this.bedbtn.TabIndex = 9;
            this.bedbtn.Text = "Bed Status";
            this.bedbtn.TextColor = System.Drawing.Color.Black;
            this.bedbtn.UseVisualStyleBackColor = false;
            this.bedbtn.Click += new System.EventHandler(this.bedbtn_Click);
            // 
            // ambulancebtn
            // 
            this.ambulancebtn.BackColor = System.Drawing.SystemColors.Control;
            this.ambulancebtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ambulancebtn.BorderColor = System.Drawing.SystemColors.Control;
            this.ambulancebtn.BorderRadius = 10;
            this.ambulancebtn.BorderSize = 0;
            this.ambulancebtn.FlatAppearance.BorderSize = 0;
            this.ambulancebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ambulancebtn.ForeColor = System.Drawing.Color.Black;
            this.ambulancebtn.Location = new System.Drawing.Point(12, 206);
            this.ambulancebtn.Name = "ambulancebtn";
            this.ambulancebtn.Size = new System.Drawing.Size(149, 40);
            this.ambulancebtn.TabIndex = 8;
            this.ambulancebtn.Text = "Ambulance";
            this.ambulancebtn.TextColor = System.Drawing.Color.Black;
            this.ambulancebtn.UseVisualStyleBackColor = false;
            this.ambulancebtn.Click += new System.EventHandler(this.ambulancebtn_Click);
            // 
            // em
            // 
            this.em.AutoSize = true;
            this.em.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.em.Location = new System.Drawing.Point(25, 89);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(35, 13);
            this.em.TabIndex = 7;
            this.em.Text = "label2";
            // 
            // apbtn
            // 
            this.apbtn.BackColor = System.Drawing.SystemColors.Control;
            this.apbtn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.apbtn.BorderColor = System.Drawing.SystemColors.Control;
            this.apbtn.BorderRadius = 10;
            this.apbtn.BorderSize = 0;
            this.apbtn.FlatAppearance.BorderSize = 0;
            this.apbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apbtn.ForeColor = System.Drawing.Color.Black;
            this.apbtn.Location = new System.Drawing.Point(12, 114);
            this.apbtn.Name = "apbtn";
            this.apbtn.Size = new System.Drawing.Size(149, 40);
            this.apbtn.TabIndex = 4;
            this.apbtn.Text = "Appointment";
            this.apbtn.TextColor = System.Drawing.Color.Black;
            this.apbtn.UseVisualStyleBackColor = false;
            this.apbtn.Click += new System.EventHandler(this.apbtn_Click);
            // 
            // app
            // 
            this.app.Controls.Add(this.apcn);
            this.app.Controls.Add(this.tkabtn);
            this.app.Controls.Add(this.dataGridView1);
            this.app.Controls.Add(this.srchbtn);
            this.app.Controls.Add(this.combosp);
            this.app.Controls.Add(this.comboloc);
            this.app.Location = new System.Drawing.Point(179, 23);
            this.app.Name = "app";
            this.app.Size = new System.Drawing.Size(474, 467);
            this.app.TabIndex = 1;
            // 
            // apcn
            // 
            this.apcn.Controls.Add(this.lbap);
            this.apcn.Controls.Add(this.combovisit);
            this.apcn.Controls.Add(this.txtptn);
            this.apcn.Controls.Add(this.txtchm);
            this.apcn.Controls.Add(this.txtdcn);
            this.apcn.Controls.Add(this.cnbtn);
            this.apcn.Location = new System.Drawing.Point(21, 242);
            this.apcn.Name = "apcn";
            this.apcn.Size = new System.Drawing.Size(441, 216);
            this.apcn.TabIndex = 5;
            this.apcn.Visible = false;
            // 
            // lbap
            // 
            this.lbap.AutoSize = true;
            this.lbap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.lbap.Location = new System.Drawing.Point(161, 160);
            this.lbap.Name = "lbap";
            this.lbap.Size = new System.Drawing.Size(116, 13);
            this.lbap.TabIndex = 6;
            this.lbap.Text = "Appointment Confirmed";
            this.lbap.Visible = false;
            // 
            // combovisit
            // 
            this.combovisit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combovisit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.combovisit.BorderSize = 1;
            this.combovisit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combovisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combovisit.ForeColor = System.Drawing.Color.DimGray;
            this.combovisit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.combovisit.Items.AddRange(new object[] {
            "Friday",
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday"});
            this.combovisit.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.combovisit.ListTextColor = System.Drawing.Color.DimGray;
            this.combovisit.Location = new System.Drawing.Point(90, 127);
            this.combovisit.MinimumSize = new System.Drawing.Size(200, 30);
            this.combovisit.Name = "combovisit";
            this.combovisit.Padding = new System.Windows.Forms.Padding(1);
            this.combovisit.Size = new System.Drawing.Size(250, 30);
            this.combovisit.TabIndex = 5;
            this.combovisit.Texts = "Visiting day";
            // 
            // txtptn
            // 
            this.txtptn.BackColor = System.Drawing.SystemColors.Window;
            this.txtptn.BorderColor = System.Drawing.Color.DarkGray;
            this.txtptn.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.txtptn.BorderRadius = 5;
            this.txtptn.BorderSize = 2;
            this.txtptn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtptn.ForeColor = System.Drawing.Color.DimGray;
            this.txtptn.Location = new System.Drawing.Point(90, 49);
            this.txtptn.Margin = new System.Windows.Forms.Padding(4);
            this.txtptn.Multiline = false;
            this.txtptn.Name = "txtptn";
            this.txtptn.Padding = new System.Windows.Forms.Padding(7);
            this.txtptn.PasswordChar = false;
            this.txtptn.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtptn.PlaceholderText = "Patient Name";
            this.txtptn.Size = new System.Drawing.Size(250, 31);
            this.txtptn.TabIndex = 4;
            this.txtptn.Texts = "";
            this.txtptn.UnderlinedStyle = false;
            // 
            // txtchm
            // 
            this.txtchm.BackColor = System.Drawing.SystemColors.Window;
            this.txtchm.BorderColor = System.Drawing.Color.DarkGray;
            this.txtchm.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.txtchm.BorderRadius = 5;
            this.txtchm.BorderSize = 2;
            this.txtchm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchm.ForeColor = System.Drawing.Color.DimGray;
            this.txtchm.Location = new System.Drawing.Point(90, 88);
            this.txtchm.Margin = new System.Windows.Forms.Padding(4);
            this.txtchm.Multiline = false;
            this.txtchm.Name = "txtchm";
            this.txtchm.Padding = new System.Windows.Forms.Padding(7);
            this.txtchm.PasswordChar = false;
            this.txtchm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtchm.PlaceholderText = "Chamber";
            this.txtchm.Size = new System.Drawing.Size(250, 31);
            this.txtchm.TabIndex = 3;
            this.txtchm.Texts = "";
            this.txtchm.UnderlinedStyle = false;
            // 
            // txtdcn
            // 
            this.txtdcn.BackColor = System.Drawing.SystemColors.Window;
            this.txtdcn.BorderColor = System.Drawing.Color.DarkGray;
            this.txtdcn.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.txtdcn.BorderRadius = 5;
            this.txtdcn.BorderSize = 2;
            this.txtdcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdcn.ForeColor = System.Drawing.Color.DimGray;
            this.txtdcn.Location = new System.Drawing.Point(90, 10);
            this.txtdcn.Margin = new System.Windows.Forms.Padding(4);
            this.txtdcn.Multiline = false;
            this.txtdcn.Name = "txtdcn";
            this.txtdcn.Padding = new System.Windows.Forms.Padding(7);
            this.txtdcn.PasswordChar = false;
            this.txtdcn.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtdcn.PlaceholderText = "Doctor Name";
            this.txtdcn.Size = new System.Drawing.Size(250, 31);
            this.txtdcn.TabIndex = 1;
            this.txtdcn.Texts = "";
            this.txtdcn.UnderlinedStyle = false;
            // 
            // cnbtn
            // 
            this.cnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.cnbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.cnbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cnbtn.BorderRadius = 5;
            this.cnbtn.BorderSize = 0;
            this.cnbtn.FlatAppearance.BorderSize = 0;
            this.cnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnbtn.ForeColor = System.Drawing.Color.White;
            this.cnbtn.Location = new System.Drawing.Point(142, 173);
            this.cnbtn.Name = "cnbtn";
            this.cnbtn.Size = new System.Drawing.Size(150, 40);
            this.cnbtn.TabIndex = 0;
            this.cnbtn.Text = "Confirm";
            this.cnbtn.TextColor = System.Drawing.Color.White;
            this.cnbtn.UseVisualStyleBackColor = false;
            this.cnbtn.Click += new System.EventHandler(this.cnbtn_Click);
            // 
            // tkabtn
            // 
            this.tkabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.tkabtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.tkabtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.tkabtn.BorderRadius = 5;
            this.tkabtn.BorderSize = 0;
            this.tkabtn.FlatAppearance.BorderSize = 0;
            this.tkabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tkabtn.ForeColor = System.Drawing.Color.White;
            this.tkabtn.Location = new System.Drawing.Point(71, 179);
            this.tkabtn.Name = "tkabtn";
            this.tkabtn.Size = new System.Drawing.Size(150, 40);
            this.tkabtn.TabIndex = 4;
            this.tkabtn.Text = "Take Appointment";
            this.tkabtn.TextColor = System.Drawing.Color.White;
            this.tkabtn.UseVisualStyleBackColor = false;
            this.tkabtn.Click += new System.EventHandler(this.tkabtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 171);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // srchbtn
            // 
            this.srchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.srchbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.srchbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.srchbtn.BorderRadius = 5;
            this.srchbtn.BorderSize = 0;
            this.srchbtn.FlatAppearance.BorderSize = 0;
            this.srchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srchbtn.ForeColor = System.Drawing.Color.White;
            this.srchbtn.Location = new System.Drawing.Point(236, 179);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(150, 40);
            this.srchbtn.TabIndex = 2;
            this.srchbtn.Text = "Search";
            this.srchbtn.TextColor = System.Drawing.Color.White;
            this.srchbtn.UseVisualStyleBackColor = false;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // combosp
            // 
            this.combosp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combosp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.combosp.BorderSize = 1;
            this.combosp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combosp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combosp.ForeColor = System.Drawing.Color.DimGray;
            this.combosp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.combosp.Items.AddRange(new object[] {
            "Hematology",
            "Cardiology",
            "Neurology",
            "Orthopedic",
            "Cancer Specialist"});
            this.combosp.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.combosp.ListTextColor = System.Drawing.Color.DimGray;
            this.combosp.Location = new System.Drawing.Point(87, 124);
            this.combosp.MinimumSize = new System.Drawing.Size(200, 30);
            this.combosp.Name = "combosp";
            this.combosp.Padding = new System.Windows.Forms.Padding(1);
            this.combosp.Size = new System.Drawing.Size(274, 30);
            this.combosp.TabIndex = 1;
            this.combosp.Texts = "Specialist";
            // 
            // comboloc
            // 
            this.comboloc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboloc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.comboloc.BorderSize = 1;
            this.comboloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboloc.ForeColor = System.Drawing.Color.DimGray;
            this.comboloc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.comboloc.Items.AddRange(new object[] {
            "Dhaka",
            "Narshingdi",
            "Gazipur",
            "Kishorganj",
            "Narayanganj",
            "Cumilla"});
            this.comboloc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboloc.ListTextColor = System.Drawing.Color.DimGray;
            this.comboloc.Location = new System.Drawing.Point(87, 72);
            this.comboloc.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboloc.Name = "comboloc";
            this.comboloc.Padding = new System.Windows.Forms.Padding(1);
            this.comboloc.Size = new System.Drawing.Size(274, 30);
            this.comboloc.TabIndex = 0;
            this.comboloc.Texts = "Location";
            // 
            // bedp
            // 
            this.bedp.Controls.Add(this.dataGridView2);
            this.bedp.Controls.Add(this.srchbedbtn);
            this.bedp.Controls.Add(this.combolocb);
            this.bedp.Location = new System.Drawing.Point(179, 23);
            this.bedp.Name = "bedp";
            this.bedp.Size = new System.Drawing.Size(462, 458);
            this.bedp.TabIndex = 6;
            this.bedp.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(111, 211);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(239, 150);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // srchbedbtn
            // 
            this.srchbedbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.srchbedbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.srchbedbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.srchbedbtn.BorderRadius = 5;
            this.srchbedbtn.BorderSize = 0;
            this.srchbedbtn.FlatAppearance.BorderSize = 0;
            this.srchbedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srchbedbtn.ForeColor = System.Drawing.Color.White;
            this.srchbedbtn.Location = new System.Drawing.Point(211, 133);
            this.srchbedbtn.Name = "srchbedbtn";
            this.srchbedbtn.Size = new System.Drawing.Size(150, 40);
            this.srchbedbtn.TabIndex = 1;
            this.srchbedbtn.Text = "Search";
            this.srchbedbtn.TextColor = System.Drawing.Color.White;
            this.srchbedbtn.UseVisualStyleBackColor = false;
            this.srchbedbtn.Click += new System.EventHandler(this.srchbedbtn_Click);
            // 
            // combolocb
            // 
            this.combolocb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combolocb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.combolocb.BorderSize = 1;
            this.combolocb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combolocb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combolocb.ForeColor = System.Drawing.Color.DimGray;
            this.combolocb.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.combolocb.Items.AddRange(new object[] {
            "Dhaka",
            "Narayanganj",
            "Kishorganj",
            "Cumilla",
            "Gazipur",
            "Narshingdi"});
            this.combolocb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.combolocb.ListTextColor = System.Drawing.Color.DimGray;
            this.combolocb.Location = new System.Drawing.Point(111, 72);
            this.combolocb.MinimumSize = new System.Drawing.Size(200, 30);
            this.combolocb.Name = "combolocb";
            this.combolocb.Padding = new System.Windows.Forms.Padding(1);
            this.combolocb.Size = new System.Drawing.Size(250, 30);
            this.combolocb.TabIndex = 0;
            this.combolocb.Texts = "Location";
            // 
            // amp
            // 
            this.amp.Controls.Add(this.dataGridView3);
            this.amp.Controls.Add(this.srcham);
            this.amp.Controls.Add(this.comboam);
            this.amp.Location = new System.Drawing.Point(179, 36);
            this.amp.Name = "amp";
            this.amp.Size = new System.Drawing.Size(462, 432);
            this.amp.TabIndex = 3;
            this.amp.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(95, 225);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.Visible = false;
            // 
            // srcham
            // 
            this.srcham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.srcham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.srcham.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.srcham.BorderRadius = 5;
            this.srcham.BorderSize = 0;
            this.srcham.FlatAppearance.BorderSize = 0;
            this.srcham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srcham.ForeColor = System.Drawing.Color.White;
            this.srcham.Location = new System.Drawing.Point(185, 108);
            this.srcham.Name = "srcham";
            this.srcham.Size = new System.Drawing.Size(150, 40);
            this.srcham.TabIndex = 1;
            this.srcham.Text = "Search";
            this.srcham.TextColor = System.Drawing.Color.White;
            this.srcham.UseVisualStyleBackColor = false;
            this.srcham.Click += new System.EventHandler(this.srcham_Click);
            // 
            // comboam
            // 
            this.comboam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.comboam.BorderSize = 1;
            this.comboam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboam.ForeColor = System.Drawing.Color.DimGray;
            this.comboam.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.comboam.Items.AddRange(new object[] {
            "Dhaka",
            "Narayanganj",
            "Narshingdi",
            "Cumilla",
            "Kishorganj",
            "Gazipur"});
            this.comboam.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboam.ListTextColor = System.Drawing.Color.DimGray;
            this.comboam.Location = new System.Drawing.Point(111, 66);
            this.comboam.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboam.Name = "comboam";
            this.comboam.Padding = new System.Windows.Forms.Padding(1);
            this.comboam.Size = new System.Drawing.Size(223, 30);
            this.comboam.TabIndex = 0;
            this.comboam.Texts = "Location";
            // 
            // bgp
            // 
            this.bgp.Controls.Add(this.dataGridView4);
            this.bgp.Controls.Add(this.srchbg);
            this.bgp.Controls.Add(this.combolocbg);
            this.bgp.Location = new System.Drawing.Point(179, 39);
            this.bgp.Name = "bgp";
            this.bgp.Size = new System.Drawing.Size(462, 417);
            this.bgp.TabIndex = 3;
            this.bgp.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(87, 211);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(323, 150);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView4.Visible = false;
            // 
            // srchbg
            // 
            this.srchbg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.srchbg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.srchbg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.srchbg.BorderRadius = 5;
            this.srchbg.BorderSize = 0;
            this.srchbg.FlatAppearance.BorderSize = 0;
            this.srchbg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srchbg.ForeColor = System.Drawing.Color.White;
            this.srchbg.Location = new System.Drawing.Point(201, 102);
            this.srchbg.Name = "srchbg";
            this.srchbg.Size = new System.Drawing.Size(150, 40);
            this.srchbg.TabIndex = 2;
            this.srchbg.Text = "Search";
            this.srchbg.TextColor = System.Drawing.Color.White;
            this.srchbg.UseVisualStyleBackColor = false;
            this.srchbg.Click += new System.EventHandler(this.srchbg_Click);
            // 
            // combolocbg
            // 
            this.combolocbg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combolocbg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.combolocbg.BorderSize = 1;
            this.combolocbg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combolocbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combolocbg.ForeColor = System.Drawing.Color.DimGray;
            this.combolocbg.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.combolocbg.Items.AddRange(new object[] {
            "Dhaka",
            "Narayanganj",
            "Narshingdi",
            "Cumilla",
            "Kishorganj",
            "Gazipur"});
            this.combolocbg.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.combolocbg.ListTextColor = System.Drawing.Color.DimGray;
            this.combolocbg.Location = new System.Drawing.Point(127, 49);
            this.combolocbg.MinimumSize = new System.Drawing.Size(200, 30);
            this.combolocbg.Name = "combolocbg";
            this.combolocbg.Padding = new System.Windows.Forms.Padding(1);
            this.combolocbg.Size = new System.Drawing.Size(223, 30);
            this.combolocbg.TabIndex = 0;
            this.combolocbg.Texts = "Location";
            // 
            // PatientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 502);
            this.Controls.Add(this.bgp);
            this.Controls.Add(this.amp);
            this.Controls.Add(this.bedp);
            this.Controls.Add(this.app);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "PatientHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.app.ResumeLayout(false);
            this.apcn.ResumeLayout(false);
            this.apcn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bedp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.amp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.bgp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RHFactory_CustomUi.RH_Button apbtn;
        private System.Windows.Forms.Label em;
        private RHFactory_CustomUi.RH_Button bloodbtn;
        private RHFactory_CustomUi.RH_Button bedbtn;
        private RHFactory_CustomUi.RH_Button ambulancebtn;
        private System.Windows.Forms.Panel app;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RHFactory_CustomUi.RH_Button srchbtn;
        private RHFactory_CustomUi.RH_ComboBox combosp;
        private RHFactory_CustomUi.RH_ComboBox comboloc;
        private System.Windows.Forms.Panel apcn;
        private System.Windows.Forms.Label lbap;
        private RHFactory_CustomUi.RH_ComboBox combovisit;
        private RHFactory_CustomUi.RH_TextBox txtptn;
        private RHFactory_CustomUi.RH_TextBox txtchm;
        private RHFactory_CustomUi.RH_TextBox txtdcn;
        private RHFactory_CustomUi.RH_Button cnbtn;
        private RHFactory_CustomUi.RH_Button tkabtn;
        private System.Windows.Forms.Panel bedp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private RHFactory_CustomUi.RH_Button srchbedbtn;
        private RHFactory_CustomUi.RH_ComboBox combolocb;
        private System.Windows.Forms.Panel amp;
        private RHFactory_CustomUi.RH_Button srcham;
        private RHFactory_CustomUi.RH_ComboBox comboam;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel bgp;
        private System.Windows.Forms.DataGridView dataGridView4;
        private RHFactory_CustomUi.RH_Button srchbg;
        private RHFactory_CustomUi.RH_ComboBox combolocbg;
    }
}