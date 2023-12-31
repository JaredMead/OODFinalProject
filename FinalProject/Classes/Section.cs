﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Section
    {
        #region Properties
        protected int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
        }
        protected string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        protected int _totalTables;
        public int totalTables
        {
            get
            {
                return _totalTables;
            }
        }
        protected int _activeTables;
        public int activeTables
        {
            get
            {
                return _activeTables;
            }
            set
            {
                int temp = value;
                if (temp > _activeTables)
                {
                    _totalTables++;
                }
                _activeTables = temp;
            }
        }
        protected System.Drawing.Color _bordercolor;
        public System.Drawing.Color bordercolor
        {
            get
            {
                return _bordercolor;
            }
            set
            {
                _bordercolor = value;
            }
        }

        protected int _totalCustomers;
        public int totalCustomers
        {
            get
            {
                return _totalCustomers;
            }
        }
        protected int _activeCustomers;
        public int activeCustomers
        {
            get
            {
                return _activeCustomers;
            }
            set
            {
                int temp = value;
                if(temp > _activeCustomers)
                {
                    _activeCustomers += temp;
                }
                _activeCustomers = temp;
            }
        }
        #endregion

        public List<Table> assignedTables = new List<Table>();

        #region Constructors
        private static int count = 0;
        public Section()
        {
            this._ID = count;
            count++;//count is below id because I want a section 0 to act as a deafult section on startup
            this.name = "Default";
        }
        #endregion

        public void asignTable(Table t)
        {//adds table to this objects assignedtable, removes the table from the previous table, and sets the assigned section of the table to this section
            this.assignedTables.Add(t);
            if(t.assignedSection != null)
            {
                t.assignedSection.assignedTables.Remove(t);
            }
            t.assignedSection = this;
        }
        ~Section()
        {
        }
    }
}
