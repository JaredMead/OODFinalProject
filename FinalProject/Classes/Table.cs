﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Table: IDeleteParty
    {
        public Table(int tableID, int maxPartySize)
        {
            this._ID = tableID;
            this._maxPartySize = maxPartySize;

        }

        #region Properties
        protected int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
        }
        protected int _maxPartySize;
        public int maxPartySize
        {
            get
            {
                return _maxPartySize;
            }
        }
        protected int _status;
        public int status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                setTableColor();
            }
        }
        protected System.Drawing.Color _backcolor;
        public System.Drawing.Color backColor
        {
            get
            {
                return _backcolor;
            }
            set
            {
                _backcolor = value;
            }
        }
        #endregion

        public Party partySat;
        public Section assignedSection;

        public void createParty(string size, string name)
        {// Chooses the apropriate party constructor from recieved inputs
            name.Trim();
            int sizeint;
            if(!int.TryParse(size, out sizeint))//no party size was given
            {
                if(name == "")//no name was given
                {
                    partySat = PartyFactory.newParty();
                }
                else//party name was given
                {
                    partySat = PartyFactory.newParty(name);
                }
            }
            else//party size was given
            {
                if(name == "")//no name was given
                {
                    partySat = PartyFactory.newParty(sizeint);
                }
                else//party name was given
                {
                    partySat = PartyFactory.newParty(sizeint, name);
                }
            }
            this.assignedSection.activeCustomers += partySat.partySize;
            this.assignedSection.activeTables++;
        }
        public void DeleteParty()
        {// stops the timer and removes party from party sat
            assignedSection.activeTables--;
            assignedSection.activeCustomers -= partySat.partySize;

            partySat.stopTimer();

            partySat = null;
        }

        internal void setTableColor()
        {
            if(status == 0)
            {
                backColor = System.Drawing.Color.White;
            }
            else if(status == 1)
            {
                backColor = System.Drawing.Color.Blue;
            }
            else if(status == 2)
            {
                backColor = System.Drawing.Color.Orange;
            }
            else
            {
                backColor = System.Drawing.Color.Red;
            }
        }
        ~Table()
        {

        }
    }
}
