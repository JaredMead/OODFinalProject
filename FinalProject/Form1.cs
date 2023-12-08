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
            var t1 = tFactory.newTable(1, 4);
            var t2 = tFactory.newTable(2, 4);
            var t3 = tFactory.newTable(3, 4);
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
        }

        private void SectionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionForm openForm = new SectionForm(SectionFactory.createdSections[SectionsList.SelectedIndex + 1]);
            openForm.ShowDialog();

            
        }

        private void table1btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[1]);
            openform.ShowDialog();
            table1btn.BackColor = TableFactory.createdTables[1].backColor;
            update();
            
        }
        private void tbl2btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[2]);
            openform.ShowDialog();
            tbl2btn.BackColor = TableFactory.createdTables[2].backColor;
            update();
        }

        private void tbl3btn_Click(object sender, EventArgs e)
        {
            TableForm openform = new TableForm(TableFactory.createdTables[3]);
            openform.ShowDialog();
            tbl3btn.BackColor = TableFactory.createdTables[3].backColor;
            update();
        }
        
        private void update()
        {
            table1btn.BackColor = TableFactory.createdTables[1].backColor;
            tbl2btn.BackColor = TableFactory.createdTables[2].backColor;
            tbl3btn.BackColor = TableFactory.createdTables[3].backColor;

            SectionsList.Update();
        }
    }
}
