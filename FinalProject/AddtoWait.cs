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
    public partial class AddtoWait : Form
    {
        public AddtoWait()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addParty(nametxt.Text, sizetxt.Text, phonetxt.Text);
            this.Close();
        }

        private void addParty(string name, string size, string phone)
        {
            WaitingParty addedParty;
            name.Trim();
            phone.Trim();
            int sizeint;
            if (!int.TryParse(size, out sizeint))//no party size was given
            {
                if (name == "")//no name was given
                {
                    if(phone == "") // No phone was given
                    {
                        addedParty = new WaitingParty();
                    }
                    else
                    {
                        addedParty = new WaitingParty(phone);
                    }
                }
                else//party name was given
                {
                    if (phone == "") // No phone was given
                    {
                        addedParty = new WaitingParty(name);
                    }
                    else
                    {
                        addedParty = new WaitingParty(name, phone);
                    }
                }
            }
            else//party size was given
            {
                if (name == "")//no name was given
                {
                    if (phone == "") // No phone was given
                    {
                        addedParty = new WaitingParty(sizeint);
                    }
                    else
                    {
                        addedParty = new WaitingParty(sizeint, phone);
                    }
                }
                else//party name was given
                {
                    if (phone == "") // No phone was given
                    {
                        addedParty = new WaitingParty(sizeint, name);
                    }
                    else
                    {
                        addedParty = new WaitingParty(sizeint, name, phone);
                    }
                }
            }
        }

    }
}
