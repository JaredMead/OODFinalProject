
namespace FinalProject
{
    partial class TableForm
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
            this.radEmpty = new System.Windows.Forms.RadioButton();
            this.radActive = new System.Windows.Forms.RadioButton();
            this.radDirty = new System.Windows.Forms.RadioButton();
            this.radOrdered = new System.Windows.Forms.RadioButton();
            this.TableOptions = new System.Windows.Forms.GroupBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.sizetxt = new System.Windows.Forms.TextBox();
            this.sizelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.TableOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // radEmpty
            // 
            this.radEmpty.AutoSize = true;
            this.radEmpty.Location = new System.Drawing.Point(13, 21);
            this.radEmpty.Name = "radEmpty";
            this.radEmpty.Size = new System.Drawing.Size(68, 21);
            this.radEmpty.TabIndex = 0;
            this.radEmpty.TabStop = true;
            this.radEmpty.Text = "Empty";
            this.radEmpty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radEmpty.UseVisualStyleBackColor = true;
            this.radEmpty.CheckedChanged += new System.EventHandler(this.radEmpty_CheckedChanged);
            // 
            // radActive
            // 
            this.radActive.AutoSize = true;
            this.radActive.Location = new System.Drawing.Point(13, 48);
            this.radActive.Name = "radActive";
            this.radActive.Size = new System.Drawing.Size(67, 21);
            this.radActive.TabIndex = 1;
            this.radActive.TabStop = true;
            this.radActive.Text = "Active";
            this.radActive.UseVisualStyleBackColor = true;
            this.radActive.CheckedChanged += new System.EventHandler(this.radActive_CheckedChanged);
            // 
            // radDirty
            // 
            this.radDirty.AutoSize = true;
            this.radDirty.Location = new System.Drawing.Point(13, 102);
            this.radDirty.Name = "radDirty";
            this.radDirty.Size = new System.Drawing.Size(58, 21);
            this.radDirty.TabIndex = 3;
            this.radDirty.TabStop = true;
            this.radDirty.Text = "Dirty";
            this.radDirty.UseVisualStyleBackColor = true;
            this.radDirty.CheckedChanged += new System.EventHandler(this.radDirty_CheckedChanged);
            // 
            // radOrdered
            // 
            this.radOrdered.AutoSize = true;
            this.radOrdered.Location = new System.Drawing.Point(13, 75);
            this.radOrdered.Name = "radOrdered";
            this.radOrdered.Size = new System.Drawing.Size(77, 21);
            this.radOrdered.TabIndex = 2;
            this.radOrdered.TabStop = true;
            this.radOrdered.Text = "Odered";
            this.radOrdered.UseVisualStyleBackColor = true;
            this.radOrdered.CheckedChanged += new System.EventHandler(this.radOrdered_CheckedChanged);
            // 
            // TableOptions
            // 
            this.TableOptions.Controls.Add(this.radOrdered);
            this.TableOptions.Controls.Add(this.radDirty);
            this.TableOptions.Controls.Add(this.radActive);
            this.TableOptions.Controls.Add(this.radEmpty);
            this.TableOptions.Location = new System.Drawing.Point(12, 12);
            this.TableOptions.Name = "TableOptions";
            this.TableOptions.Size = new System.Drawing.Size(335, 133);
            this.TableOptions.TabIndex = 4;
            this.TableOptions.TabStop = false;
            this.TableOptions.Text = "Table Options";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(108, 289);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(127, 34);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sizetxt
            // 
            this.sizetxt.Location = new System.Drawing.Point(25, 184);
            this.sizetxt.Name = "sizetxt";
            this.sizetxt.Size = new System.Drawing.Size(100, 22);
            this.sizetxt.TabIndex = 6;
            // 
            // sizelbl
            // 
            this.sizelbl.AutoSize = true;
            this.sizelbl.Location = new System.Drawing.Point(22, 164);
            this.sizelbl.Name = "sizelbl";
            this.sizelbl.Size = new System.Drawing.Size(161, 17);
            this.sizelbl.TabIndex = 7;
            this.sizelbl.Text = "Please Enter Party Size:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(22, 209);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(171, 17);
            this.namelbl.TabIndex = 9;
            this.namelbl.Text = "Please Enter Party Name:";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(25, 229);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(180, 22);
            this.nametxt.TabIndex = 8;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 335);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.sizelbl);
            this.Controls.Add(this.sizetxt);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.TableOptions);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.TableOptions.ResumeLayout(false);
            this.TableOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radEmpty;
        private System.Windows.Forms.RadioButton radActive;
        private System.Windows.Forms.RadioButton radDirty;
        private System.Windows.Forms.RadioButton radOrdered;
        private System.Windows.Forms.GroupBox TableOptions;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox sizetxt;
        private System.Windows.Forms.Label sizelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox nametxt;
    }
}