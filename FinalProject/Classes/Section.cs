using System;
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
                _activeTables = value;
                if(value > 0)
                {
                    _totalTables += value;
                }
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
                _activeCustomers = value;
                if (value > 0)
                {
                    _totalCustomers += value;
                }
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
        }
        #endregion

        public void asignTable(Table t)
        {//adds table to this objects assignedtable, removes the table from the previous table, and sets the assigned section of the table to this section
            this.assignedTables.Add(t);
            t.assignedSection.assignedTables.Remove(t);
            t.assignedSection = this;
        }
        ~Section()
        {
            //set all tables in setion to section 0
        }
    }
}
