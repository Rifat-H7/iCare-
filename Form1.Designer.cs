
namespace iCare
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.rH_ProgressBar1 = new RHFactory_CustomUi.RH_ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rH_ProgressBar1
            // 
            this.rH_ProgressBar1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rH_ProgressBar1.ChannelHeight = 6;
            this.rH_ProgressBar1.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.rH_ProgressBar1.ForeColor = System.Drawing.Color.White;
            this.rH_ProgressBar1.Location = new System.Drawing.Point(-1, 215);
            this.rH_ProgressBar1.Name = "rH_ProgressBar1";
            this.rH_ProgressBar1.ShowMaximun = false;
            this.rH_ProgressBar1.ShowValue = RHFactory_CustomUi.TextPosition.None;
            this.rH_ProgressBar1.Size = new System.Drawing.Size(454, 11);
            this.rH_ProgressBar1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.rH_ProgressBar1.SliderHeight = 6;
            this.rH_ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.rH_ProgressBar1.SymbolAfter = "";
            this.rH_ProgressBar1.SymbolBefore = "";
            this.rH_ProgressBar1.TabIndex = 0;
            this.rH_ProgressBar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iCare.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(451, 226);
            this.Controls.Add(this.rH_ProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCare";
            this.ResumeLayout(false);

        }

        #endregion

        private RHFactory_CustomUi.RH_ProgressBar rH_ProgressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

