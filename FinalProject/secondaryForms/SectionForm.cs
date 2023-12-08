using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SectionForm : Form
    {
        private Section selected;

        public SectionForm(Section selected)
        {
            this.selected = selected;
            InitializeComponent();

            settxtboxs();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            selected.name = nametxt.Text;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void asignbtn_Click(object sender, EventArgs e)
        {
            int target = int.Parse(asigntxt.Text);
            
            foreach(Table t in TableFactory.createdTables)
            {
                if(target == t.ID)
                {
                    selected.asignTable(t);
                    break;
                }
            }
        }

        private void settxtboxs()
        {
            nametxt.Text = selected.name;
            tbltxt.Text = selected.assignedTables.Count().ToString();
            activeTtxt.Text = selected.activeTables.ToString();
            totalTtxt.Text = selected.totalTables.ToString();
            activeCtxt.Text = selected.activeCustomers.ToString();
            totalCtxt.Text = selected.totalCustomers.ToString();
        }
    }
}
