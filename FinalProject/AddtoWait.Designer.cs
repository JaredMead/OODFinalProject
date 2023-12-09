
namespace FinalProject
{
    partial class AddtoWait
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
            this.phonelbl = new System.Windows.Forms.Label();
            this.sizelbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.sizetxt = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(12, 9);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(49, 17);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Name:";
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(12, 109);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(107, 17);
            this.phonelbl.TabIndex = 1;
            this.phonelbl.Text = "Phone Number:";
            // 
            // sizelbl
            // 
            this.sizelbl.AutoSize = true;
            this.sizelbl.Location = new System.Drawing.Point(12, 64);
            this.sizelbl.Name = "sizelbl";
            this.sizelbl.Size = new System.Drawing.Size(39, 17);
            this.sizelbl.TabIndex = 2;
            this.sizelbl.Text = "Size:";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(67, 9);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 22);
            this.nametxt.TabIndex = 3;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(67, 129);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(100, 22);
            this.phonetxt.TabIndex = 4;
            // 
            // sizetxt
            // 
            this.sizetxt.Location = new System.Drawing.Point(67, 64);
            this.sizetxt.Name = "sizetxt";
            this.sizetxt.Size = new System.Drawing.Size(100, 22);
            this.sizetxt.TabIndex = 5;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(54, 171);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // AddtoWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 211);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.sizetxt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.sizelbl);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.namelbl);
            this.Name = "AddtoWait";
            this.Text = "AddtoWait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.Label sizelbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox sizetxt;
        private System.Windows.Forms.Button addbtn;
    }
}