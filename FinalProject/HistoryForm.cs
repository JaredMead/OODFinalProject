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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();

            var listBox = new ListBox
            {
                DataSource = PartyFactory.createdParties,
                Dock = DockStyle.Fill,
                FormattingEnabled = true
            };
            historylb.Format += (sender, args) =>
            {
                var prty = (Party)args.Value;
                args.Value = string.Format("");
            };
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
