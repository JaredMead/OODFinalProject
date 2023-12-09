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
    public partial class WaitlistForm : Form
    {
        public WaitlistForm()
        {
            InitializeComponent();

            var listBox = new ListBox
            {
                DataSource = WaitingParty.waitlist,
                Dock = DockStyle.Fill,
                FormattingEnabled = true
            };
            waitlistlb.Format += (sender, args) =>
            {
                var prty = (WaitingParty)args.Value;
                args.Value = string.Format("{0},    {1},    {2},        {3}", prty.name, prty.partySize,prty.phoneNumber, prty.time);
            };

            foreach (WaitingParty p in WaitingParty.waitlist)
            {
                waitlistlb.Items.Add(p);
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
