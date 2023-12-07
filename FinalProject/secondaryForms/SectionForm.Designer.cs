
namespace FinalProject
{
    partial class SectionForm
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
            this.namelbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.asignbtn = new System.Windows.Forms.Button();
            this.tbllbl = new System.Windows.Forms.Label();
            this.tbltxt = new System.Windows.Forms.TextBox();
            this.activeTlbl = new System.Windows.Forms.Label();
            this.totalTlbl = new System.Windows.Forms.Label();
            this.activeClbl = new System.Windows.Forms.Label();
            this.totalClbl = new System.Windows.Forms.Label();
            this.activeTtxt = new System.Windows.Forms.TextBox();
            this.totalCtxt = new System.Windows.Forms.TextBox();
            this.activeCtxt = new System.Windows.Forms.TextBox();
            this.totalTtxt = new System.Windows.Forms.TextBox();
            this.asignlbl = new System.Windows.Forms.Label();
            this.asigntxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(68, 17);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(144, 17);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Please Enter a name:";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(68, 37);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(171, 22);
            this.nametxt.TabIndex = 1;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(9, 314);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(112, 30);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // asignbtn
            // 
            this.asignbtn.Location = new System.Drawing.Point(127, 314);
            this.asignbtn.Name = "asignbtn";
            this.asignbtn.Size = new System.Drawing.Size(112, 29);
            this.asignbtn.TabIndex = 3;
            this.asignbtn.Text = "Asign Table";
            this.asignbtn.UseVisualStyleBackColor = true;
            this.asignbtn.Click += new System.EventHandler(this.asignbtn_Click);
            // 
            // tbllbl
            // 
            this.tbllbl.AutoSize = true;
            this.tbllbl.Location = new System.Drawing.Point(7, 17);
            this.tbllbl.Name = "tbllbl";
            this.tbllbl.Size = new System.Drawing.Size(51, 17);
            this.tbllbl.TabIndex = 4;
            this.tbllbl.Text = "Tables";
            // 
            // tbltxt
            // 
            this.tbltxt.Location = new System.Drawing.Point(10, 37);
            this.tbltxt.Name = "tbltxt";
            this.tbltxt.Size = new System.Drawing.Size(48, 22);
            this.tbltxt.TabIndex = 5;
            // 
            // activeTlbl
            // 
            this.activeTlbl.AutoSize = true;
            this.activeTlbl.Location = new System.Drawing.Point(12, 80);
            this.activeTlbl.Name = "activeTlbl";
            this.activeTlbl.Size = new System.Drawing.Size(101, 17);
            this.activeTlbl.TabIndex = 6;
            this.activeTlbl.Text = "Active Tables: ";
            // 
            // totalTlbl
            // 
            this.totalTlbl.AutoSize = true;
            this.totalTlbl.Location = new System.Drawing.Point(12, 112);
            this.totalTlbl.Name = "totalTlbl";
            this.totalTlbl.Size = new System.Drawing.Size(91, 17);
            this.totalTlbl.TabIndex = 7;
            this.totalTlbl.Text = "Total Tables:";
            // 
            // activeClbl
            // 
            this.activeClbl.AutoSize = true;
            this.activeClbl.Location = new System.Drawing.Point(12, 146);
            this.activeClbl.Name = "activeClbl";
            this.activeClbl.Size = new System.Drawing.Size(121, 17);
            this.activeClbl.TabIndex = 8;
            this.activeClbl.Text = "Active Customers:";
            // 
            // totalClbl
            // 
            this.totalClbl.AutoSize = true;
            this.totalClbl.Location = new System.Drawing.Point(12, 182);
            this.totalClbl.Name = "totalClbl";
            this.totalClbl.Size = new System.Drawing.Size(115, 17);
            this.totalClbl.TabIndex = 9;
            this.totalClbl.Text = "Total Customers:";
            // 
            // activeTtxt
            // 
            this.activeTtxt.Location = new System.Drawing.Point(139, 80);
            this.activeTtxt.Name = "activeTtxt";
            this.activeTtxt.Size = new System.Drawing.Size(100, 22);
            this.activeTtxt.TabIndex = 10;
            // 
            // totalCtxt
            // 
            this.totalCtxt.Location = new System.Drawing.Point(139, 182);
            this.totalCtxt.Name = "totalCtxt";
            this.totalCtxt.Size = new System.Drawing.Size(100, 22);
            this.totalCtxt.TabIndex = 11;
            // 
            // activeCtxt
            // 
            this.activeCtxt.Location = new System.Drawing.Point(139, 146);
            this.activeCtxt.Name = "activeCtxt";
            this.activeCtxt.Size = new System.Drawing.Size(100, 22);
            this.activeCtxt.TabIndex = 12;
            // 
            // totalTtxt
            // 
            this.totalTtxt.Location = new System.Drawing.Point(139, 112);
            this.totalTtxt.Name = "totalTtxt";
            this.totalTtxt.Size = new System.Drawing.Size(100, 22);
            this.totalTtxt.TabIndex = 13;
            // 
            // asignlbl
            // 
            this.asignlbl.AutoSize = true;
            this.asignlbl.Location = new System.Drawing.Point(7, 207);
            this.asignlbl.Name = "asignlbl";
            this.asignlbl.Size = new System.Drawing.Size(244, 34);
            this.asignlbl.TabIndex = 14;
            this.asignlbl.Text = "Enter Table Number you want to add \r\nto this section here:";
            // 
            // asigntxt
            // 
            this.asigntxt.Location = new System.Drawing.Point(139, 228);
            this.asigntxt.Name = "asigntxt";
            this.asigntxt.Size = new System.Drawing.Size(100, 22);
            this.asigntxt.TabIndex = 15;
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 355);
            this.Controls.Add(this.asigntxt);
            this.Controls.Add(this.asignlbl);
            this.Controls.Add(this.totalTtxt);
            this.Controls.Add(this.activeCtxt);
            this.Controls.Add(this.totalCtxt);
            this.Controls.Add(this.activeTtxt);
            this.Controls.Add(this.totalClbl);
            this.Controls.Add(this.activeClbl);
            this.Controls.Add(this.totalTlbl);
            this.Controls.Add(this.activeTlbl);
            this.Controls.Add(this.tbltxt);
            this.Controls.Add(this.tbllbl);
            this.Controls.Add(this.asignbtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.namelbl);
            this.Name = "SectionForm";
            this.Text = "SectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button asignbtn;
        private System.Windows.Forms.Label tbllbl;
        public System.Windows.Forms.TextBox tbltxt;
        private System.Windows.Forms.Label activeTlbl;
        private System.Windows.Forms.Label totalTlbl;
        private System.Windows.Forms.Label activeClbl;
        private System.Windows.Forms.Label totalClbl;
        private System.Windows.Forms.TextBox activeTtxt;
        private System.Windows.Forms.TextBox totalCtxt;
        private System.Windows.Forms.TextBox activeCtxt;
        private System.Windows.Forms.TextBox totalTtxt;
        private System.Windows.Forms.Label asignlbl;
        private System.Windows.Forms.TextBox asigntxt;
    }
}