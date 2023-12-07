﻿using System;
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
    public partial class TableForm : Form
    {
        Table t;
        public TableForm(Table t)
        {
            this.t = t;
            InitializeComponent();

            if(t.tableStatus == 0)
            {
                radEmpty.Checked = true;
            }
            else if(t.tableStatus == 1)
            {
                radActive.Checked = true;
                settxtboxs();
            }
            else if(t.tableStatus == 2)
            {
                radOrdered.Checked = true;
                settxtboxs();
            }
            else if(t.tableStatus == 3)
            {
                radDirty.Checked = true;
            }
        }

        private void radEmpty_CheckedChanged(object sender, EventArgs e)
        {
            t.tableStatus = 0;
        }
        private void radActive_CheckedChanged(object sender, EventArgs e)
        {
            t.tableStatus = 1;
        }
        private void radOrdered_CheckedChanged(object sender, EventArgs e) 
        { 
            t.tableStatus = 2;
        }
        private void radDirty_CheckedChanged(object sender, EventArgs e)
        {
            t.tableStatus = 3;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if(t.tableStatus == 0)
            {
                t.backColor = Color.Gray;
                if(t.partySat != null)
                {
                    t.deleteParty();
                }
            }
            else if(t.tableStatus == 1)
            {
                t.backColor = Color.Blue;
                if(t.partySat == null)
                {
                    t.createParty(sizetxt.Text, nametxt.Text);
                }
            }
            else if(t.tableStatus == 2 && t.partySat != null)
            {
                t.backColor = Color.Orange;
            }
            else if(t.tableStatus == 3)
            {
                t.backColor = Color.Red;
                if(t.partySat != null)
                {
                    t.deleteParty();
                }
            }
            this.Close();
        }

        private void settxtboxs()
        {
            if(t.partySat != null)
            {
                nametxt.Text = t.partySat.partyName;
                sizetxt.Text = t.partySat.partySize.ToString();
            }
        }
    }
}