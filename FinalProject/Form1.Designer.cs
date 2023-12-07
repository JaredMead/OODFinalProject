
namespace FinalProject
{
    partial class tableOrganiser
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
            this.table1btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SectionsList = new System.Windows.Forms.ListBox();
            this.createSectionBtn = new System.Windows.Forms.Button();
            this.idlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.activelbl = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.activetxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.tablestxt = new System.Windows.Forms.TextBox();
            this.tableslbl = new System.Windows.Forms.Label();
            this.tbl3btn = new System.Windows.Forms.Button();
            this.tbl2btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // table1btn
            // 
            this.table1btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.table1btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.table1btn.Location = new System.Drawing.Point(845, 116);
            this.table1btn.Name = "table1btn";
            this.table1btn.Size = new System.Drawing.Size(70, 70);
            this.table1btn.TabIndex = 0;
            this.table1btn.Text = "1\r\nTimer";
            this.table1btn.UseVisualStyleBackColor = false;
            this.table1btn.Click += new System.EventHandler(this.table1btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(86, 548);
            this.listBox1.TabIndex = 1;
            // 
            // SectionsList
            // 
            this.SectionsList.FormattingEnabled = true;
            this.SectionsList.ItemHeight = 16;
            this.SectionsList.Location = new System.Drawing.Point(104, 116);
            this.SectionsList.Name = "SectionsList";
            this.SectionsList.Size = new System.Drawing.Size(273, 420);
            this.SectionsList.TabIndex = 2;
            this.SectionsList.SelectedIndexChanged += new System.EventHandler(this.SectionsList_SelectedIndexChanged);
            // 
            // createSectionBtn
            // 
            this.createSectionBtn.Location = new System.Drawing.Point(104, 536);
            this.createSectionBtn.Name = "createSectionBtn";
            this.createSectionBtn.Size = new System.Drawing.Size(143, 26);
            this.createSectionBtn.TabIndex = 8;
            this.createSectionBtn.Text = "Create Section";
            this.createSectionBtn.UseVisualStyleBackColor = true;
            this.createSectionBtn.Click += new System.EventHandler(this.createSectionBtn_Click);
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(165, 58);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(21, 17);
            this.idlbl.TabIndex = 9;
            this.idlbl.Text = "ID";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(202, 58);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(45, 17);
            this.namelbl.TabIndex = 10;
            this.namelbl.Text = "Name";
            // 
            // activelbl
            // 
            this.activelbl.AutoSize = true;
            this.activelbl.Location = new System.Drawing.Point(265, 58);
            this.activelbl.Name = "activelbl";
            this.activelbl.Size = new System.Drawing.Size(46, 17);
            this.activelbl.TabIndex = 11;
            this.activelbl.Text = "Active";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Location = new System.Drawing.Point(327, 58);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(40, 17);
            this.totallbl.TabIndex = 12;
            this.totallbl.Text = "Total";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(168, 87);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(27, 22);
            this.idtxt.TabIndex = 13;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(201, 87);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(45, 22);
            this.nametxt.TabIndex = 14;
            // 
            // activetxt
            // 
            this.activetxt.Location = new System.Drawing.Point(264, 87);
            this.activetxt.Name = "activetxt";
            this.activetxt.Size = new System.Drawing.Size(46, 22);
            this.activetxt.TabIndex = 15;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(327, 89);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(39, 22);
            this.totaltxt.TabIndex = 16;
            // 
            // tablestxt
            // 
            this.tablestxt.Location = new System.Drawing.Point(111, 87);
            this.tablestxt.Name = "tablestxt";
            this.tablestxt.Size = new System.Drawing.Size(48, 22);
            this.tablestxt.TabIndex = 17;
            // 
            // tableslbl
            // 
            this.tableslbl.AutoSize = true;
            this.tableslbl.Location = new System.Drawing.Point(108, 58);
            this.tableslbl.Name = "tableslbl";
            this.tableslbl.Size = new System.Drawing.Size(51, 17);
            this.tableslbl.TabIndex = 18;
            this.tableslbl.Text = "Tables";
            // 
            // tbl3btn
            // 
            this.tbl3btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbl3btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbl3btn.Location = new System.Drawing.Point(1032, 116);
            this.tbl3btn.Name = "tbl3btn";
            this.tbl3btn.Size = new System.Drawing.Size(70, 70);
            this.tbl3btn.TabIndex = 19;
            this.tbl3btn.Text = "3\nTimer";
            this.tbl3btn.UseVisualStyleBackColor = false;
            this.tbl3btn.Click += new System.EventHandler(this.tbl3btn_Click);
            // 
            // tbl2btn
            // 
            this.tbl2btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbl2btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbl2btn.Location = new System.Drawing.Point(936, 116);
            this.tbl2btn.Name = "tbl2btn";
            this.tbl2btn.Size = new System.Drawing.Size(70, 70);
            this.tbl2btn.TabIndex = 20;
            this.tbl2btn.Text = "2\r\nTimer";
            this.tbl2btn.UseVisualStyleBackColor = false;
            this.tbl2btn.Click += new System.EventHandler(this.tbl2btn_Click);
            // 
            // tableOrganiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 567);
            this.Controls.Add(this.tbl2btn);
            this.Controls.Add(this.tbl3btn);
            this.Controls.Add(this.tableslbl);
            this.Controls.Add(this.tablestxt);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.activetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.activelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.createSectionBtn);
            this.Controls.Add(this.SectionsList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.table1btn);
            this.Name = "tableOrganiser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button table1btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox SectionsList;
        private System.Windows.Forms.Button createSectionBtn;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label activelbl;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox activetxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.TextBox tablestxt;
        private System.Windows.Forms.Label tableslbl;
        private System.Windows.Forms.Button tbl3btn;
        private System.Windows.Forms.Button tbl2btn;
    }
}

