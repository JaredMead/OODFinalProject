using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Section
    {
        public int ID;
        private static int count = 0;

        public string serverName;

        int numberOfTables;

        public int totalTables;
        private int _activeTables;
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
                    totalTables += value;
                }
            }
        }

        int totalCustomers;
        public int activeCustomers;

        public List<Table> assignedTables = new List<Table>();

        public Section()
        {
            this.ID = count;
            count++;
            //asign ID based on the lowest number that is not already assigned

        }
        void editTotals(int value)
        {
            
        }
        public void asignTable(Table t)
        {
            assignedTables.Add(t);
            t.assignedSection = this;
            numberOfTables = assignedTables.Count();
        }
        ~Section()
        {
            //set all tables in setion to section 0
        }
    }
}
