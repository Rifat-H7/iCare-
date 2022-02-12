
namespace iCare
{
    partial class AdminHome
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
            this.txtemsr = new RHFactory_CustomUi.RH_TextBox();
            this.srchbtn = new RHFactory_CustomUi.RH_Button();
            this.ptrb = new RHFactory_CustomUi.RH_RadioButton();
            this.vrb = new RHFactory_CustomUi.RH_RadioButton();
            this.docrb = new RHFactory_CustomUi.RH_RadioButton();
            this.dltbtn = new RHFactory_CustomUi.RH_Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdlt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtemsr
            // 
            this.txtemsr.BackColor = System.Drawing.SystemColors.Window;
            this.txtemsr.BorderColor = System.Drawing.Color.DarkGray;
            this.txtemsr.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.txtemsr.BorderRadius = 5;
            this.txtemsr.BorderSize = 2;
            this.txtemsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemsr.ForeColor = System.Drawing.Color.DimGray;
            this.txtemsr.Location = new System.Drawing.Point(167, 96);
            this.txtemsr.Margin = new System.Windows.Forms.Padding(4);
            this.txtemsr.Multiline = false;
            this.txtemsr.Name = "txtemsr";
            this.txtemsr.Padding = new System.Windows.Forms.Padding(7);
            this.txtemsr.PasswordChar = false;
            this.txtemsr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtemsr.PlaceholderText = "Email:";
            this.txtemsr.Size = new System.Drawing.Size(327, 31);
            this.txtemsr.TabIndex = 0;
            this.txtemsr.Texts = "";
            this.txtemsr.UnderlinedStyle = false;
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
            this.srchbtn.Location = new System.Drawing.Point(344, 208);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(150, 31);
            this.srchbtn.TabIndex = 1;
            this.srchbtn.Text = "Search";
            this.srchbtn.TextColor = System.Drawing.Color.White;
            this.srchbtn.UseVisualStyleBackColor = false;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // ptrb
            // 
            this.ptrb.AutoSize = true;
            this.ptrb.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.ptrb.Location = new System.Drawing.Point(167, 157);
            this.ptrb.MinimumSize = new System.Drawing.Size(0, 21);
            this.ptrb.Name = "ptrb";
            this.ptrb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ptrb.Size = new System.Drawing.Size(68, 21);
            this.ptrb.TabIndex = 2;
            this.ptrb.TabStop = true;
            this.ptrb.Text = "Patient";
            this.ptrb.UnCheckedColor = System.Drawing.Color.Gray;
            this.ptrb.UseVisualStyleBackColor = true;
            // 
            // vrb
            // 
            this.vrb.AutoSize = true;
            this.vrb.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.vrb.Location = new System.Drawing.Point(314, 157);
            this.vrb.MinimumSize = new System.Drawing.Size(0, 21);
            this.vrb.Name = "vrb";
            this.vrb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vrb.Size = new System.Drawing.Size(80, 21);
            this.vrb.TabIndex = 3;
            this.vrb.TabStop = true;
            this.vrb.Text = "Volunteer";
            this.vrb.UnCheckedColor = System.Drawing.Color.Gray;
            this.vrb.UseVisualStyleBackColor = true;
            // 
            // docrb
            // 
            this.docrb.AutoSize = true;
            this.docrb.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.docrb.Location = new System.Drawing.Point(241, 157);
            this.docrb.MinimumSize = new System.Drawing.Size(0, 21);
            this.docrb.Name = "docrb";
            this.docrb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.docrb.Size = new System.Drawing.Size(67, 21);
            this.docrb.TabIndex = 4;
            this.docrb.TabStop = true;
            this.docrb.Text = "Doctor";
            this.docrb.UnCheckedColor = System.Drawing.Color.Gray;
            this.docrb.UseVisualStyleBackColor = true;
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.dltbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.dltbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dltbtn.BorderRadius = 5;
            this.dltbtn.BorderSize = 0;
            this.dltbtn.FlatAppearance.BorderSize = 0;
            this.dltbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dltbtn.ForeColor = System.Drawing.Color.White;
            this.dltbtn.Location = new System.Drawing.Point(167, 208);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(150, 31);
            this.dltbtn.TabIndex = 5;
            this.dltbtn.Text = "Delete User";
            this.dltbtn.TextColor = System.Drawing.Color.White;
            this.dltbtn.UseVisualStyleBackColor = false;
            this.dltbtn.Visible = false;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 135);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADMIN HOME";
            // 
            // lbdlt
            // 
            this.lbdlt.AutoSize = true;
            this.lbdlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))));
            this.lbdlt.Location = new System.Drawing.Point(289, 254);
            this.lbdlt.Name = "lbdlt";
            this.lbdlt.Size = new System.Drawing.Size(81, 13);
            this.lbdlt.TabIndex = 8;
            this.lbdlt.Text = "User Deleted";
            this.lbdlt.Visible = false;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 502);
            this.Controls.Add(this.lbdlt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.docrb);
            this.Controls.Add(this.vrb);
            this.Controls.Add(this.ptrb);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.txtemsr);
            this.MaximizeBox = false;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminHome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RHFactory_CustomUi.RH_TextBox txtemsr;
        private RHFactory_CustomUi.RH_Button srchbtn;
        private RHFactory_CustomUi.RH_RadioButton ptrb;
        private RHFactory_CustomUi.RH_RadioButton vrb;
        private RHFactory_CustomUi.RH_RadioButton docrb;
        private RHFactory_CustomUi.RH_Button dltbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbdlt;
    }
}