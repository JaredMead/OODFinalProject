
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
            this.label1 = new System.Windows.Forms.Label();
            this.asigntxt = new System.Windows.Forms.TextBox();
            this.asignbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(12, 464);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(100, 23);
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
            this.waitlistlb.Size = new System.Drawing.Size(253, 356);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 51);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please Enter the table \r\nyou want to asign the \r\nselected party to:\r\n";
            // 
            // asigntxt
            // 
            this.asigntxt.Location = new System.Drawing.Point(155, 427);
            this.asigntxt.Name = "asigntxt";
            this.asigntxt.Size = new System.Drawing.Size(110, 22);
            this.asigntxt.TabIndex = 13;
            // 
            // asignbtn
            // 
            this.asignbtn.Location = new System.Drawing.Point(165, 455);
            this.asignbtn.Name = "asignbtn";
            this.asignbtn.Size = new System.Drawing.Size(100, 32);
            this.asignbtn.TabIndex = 14;
            this.asignbtn.Text = "Assign Table";
            this.asignbtn.UseVisualStyleBackColor = true;
            this.asignbtn.Click += new System.EventHandler(this.asignbtn_Click);
            // 
            // WaitlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 499);
            this.Controls.Add(this.asignbtn);
            this.Controls.Add(this.asigntxt);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox asigntxt;
        private System.Windows.Forms.Button asignbtn;
    }
}