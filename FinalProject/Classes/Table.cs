using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Table
    {
        public Table(int tableID, int maxPartySize)
        {
            //check if tableID already exists

            this.tableID = tableID;
            this.maxPartySize = maxPartySize;

        }

        int tableID;

        int maxPartySize;

        public int tableStatus = 0;

        private Party _partySat;
        public Party partySat
        {
            get
            {
                return _partySat;
            }
            set
            {
                _partySat = value;
            }
        }

        public System.Drawing.Color backColor;

        public Section assignedSection;

        public void createParty(string size, string name)
        {
            name.Trim();
            int sizeint;
            if(!int.TryParse(size, out sizeint))
            {
                if(name == "")
                {
                    partySat = new Party();
                }
                else
                {
                    partySat = new Party(name);
                }
            }
            else
            {
                if(name == "")
                {
                    partySat = new Party(sizeint);
                }
                else
                {
                    partySat = new Party(sizeint, name);
                }
            }
            assignedSection.activeCustomers += partySat.partySize;
            assignedSection.activeTables++;
        }
        public void deleteParty()
        {
            assignedSection.activeTables--;
            assignedSection.activeCustomers -= partySat.partySize;

            partySat.timer.Stop();
            partySat.time = partySat.timer.ElapsedMilliseconds;

            //send the current party to a list or find a way to use the partyfactory accross multiple table objects
            partySat = null;
        }

        void tableSizeChecker()
        {
            if(partySat.partySize > maxPartySize)
            {
                //send warning to log
            }
        }

        ~Table()
        {

        }
    }
}
