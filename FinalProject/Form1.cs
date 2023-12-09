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
    public partial class tableOrganiser : Form
    {
        TableFactory tFactory = new TableFactory();
        SectionFactory sFactory = new SectionFactory();
        PartyFactory pfactory = new PartyFactory();
        Section defaultsec;
        public tableOrganiser()
        {
            InitializeComponent();
            defaultsec = SectionFactory.newSection();
            var t0 = tFactory.newTable(0, 0);
            for(int x = 1; x<10; x++)
            {
                var table = tFactory.newTable(x, 4);
            }
            foreach(Table t in TableFactory.createdTables)
            {
                defaultsec.asignTable(t);
            }


            #region Formating
            var listBox = new ListBox
            {
                DataSource = SectionFactory.createdSections,
                Dock = DockStyle.Fill,
                FormattingEnabled = true,
            };
            SectionsList.Format += (sender, args) =>
            {
                var section = (Section) args.Value;
                args.Value = string.Format("{0},        {1},                    {2},        {3}", section.assignedTables.Count(), section.name, section.activeTables,section.totalTables);
            };
            #endregion

            update();
        }        

        private void createSectionBtn_Click(object sender, EventArgs e)
        {
            var sectionobj = SectionFactory.newSection();
            SectionsList.Items.Add(sectionobj);
            update();
        }

        private void SectionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionForm openForm = new SectionForm(SectionFactory.createdSections[SectionsList.SelectedIndex + 1]);
            openForm.ShowDialog();
            update();
            
        }
        #region Table Buttons
        private void tbl1btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[1]);
            openform.ShowDialog();
            update();
        }
        private void tbl2btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[2]);
            openform.ShowDialog();
            update();
        }
        private void tbl3btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[3]);
            openform.ShowDialog();
            update();
        }
        private void table4btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[4]);
            openform.ShowDialog();
            update();
        }
        private void tbl5btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[5]);
            openform.ShowDialog();
            update();
        }
        private void tbl6btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[6]);
            openform.ShowDialog();
            update();
        }
        private void tbl7btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[7]);
            openform.ShowDialog();
            update();
        }
        private void tbl8btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[8]);
            openform.ShowDialog();
            update();
        }
        private void tbl9btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[9]);
            openform.ShowDialog();
            update();
        }
        #endregion

        private void historybtn_Click(object sender, EventArgs e)
        {
            HistoryForm openform = new HistoryForm();
            openform.ShowDialog();
        }
        private void waitlistbtn_Click(object sender, EventArgs e)
        {
            WaitlistForm openform = new WaitlistForm();
            openform.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddtoWait openform = new AddtoWait();
            openform.ShowDialog();
        }
        private void update()
        {
            tbl1btn.BackColor = TableFactory.createdTables[1].backColor;
            tbl2btn.BackColor = TableFactory.createdTables[2].backColor;
            tbl3btn.BackColor = TableFactory.createdTables[3].backColor;
            tbl4btn.BackColor = TableFactory.createdTables[4].backColor;
            tbl5btn.BackColor = TableFactory.createdTables[5].backColor;
            tbl6btn.BackColor = TableFactory.createdTables[6].backColor;
            tbl7btn.BackColor = TableFactory.createdTables[7].backColor;
            tbl8btn.BackColor = TableFactory.createdTables[8].backColor;
            tbl9btn.BackColor = TableFactory.createdTables[9].backColor;

            
        }
    }
}
