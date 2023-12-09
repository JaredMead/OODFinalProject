
namespace FinalProject
{
    partial class WaitlistForm
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
            this.closebtn = new System.Windows.Forms.Button();
            this.timelbl = new System.Windows.Forms.Label();
            this.sizelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.waitlistlb = new System.Windows.Forms.ListBox();
            this.phonelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(87, 442);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 10;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(226, 9);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(39, 17);
            this.timelbl.TabIndex = 9;
            this.timelbl.Text = "Time";
            // 
            // sizelbl
            // 
            this.sizelbl.AutoSize = true;
            this.sizelbl.Location = new System.Drawing.Point(63, 9);
            this.sizelbl.Name = "sizelbl";
            this.sizelbl.Size = new System.Drawing.Size(35, 17);
            this.sizelbl.TabIndex = 8;
            this.sizelbl.Text = "Size";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(12, 9);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(45, 17);
            this.namelbl.TabIndex = 7;
            this.namelbl.Text = "Name";
            // 
            // waitlistlb
            // 
            this.waitlistlb.FormattingEnabled = true;
            this.waitlistlb.ItemHeight = 16;
            this.waitlistlb.Location = new System.Drawing.Point(12, 44);
            this.waitlistlb.Name = "waitlistlb";
            this.waitlistlb.Size = new System.Drawing.Size(253, 388);
            this.waitlistlb.TabIndex = 6;
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(104, 9);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(103, 17);
            this.phonelbl.TabIndex = 11;
            this.phonelbl.Text = "Phone Number";
            // 
            // WaitlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 482);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.sizelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.waitlistlb);
            this.Name = "WaitlistForm";
            this.Text = "WaitlistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label sizelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.ListBox waitlistlb;
        private System.Windows.Forms.Label phonelbl;
    }
}